using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using UtilitiesLib;
using HomeForSaleBLL;
using HomeForSaleBLL.BuildingTypes;

namespace Assignment1
{
    //Authors: Henrik Sigeman and My Adolfsson
    public partial class Form1 : Form
    {
        //List of Estate objects, can be of any type.
        EstateManager Estates;
        //All the boxes in the edit-part of the window, organized for easy manipulation.
        TextBox[] EstateInfoBoxes;
        //List of Estate objects converted into strings to be shown in the list of estates in the list part of the window.
        LinkedList<string> EstateListItems;
        //Currently selected estate, used for replacing an object.
        int selectedEstate;
        //Flag which tells the program wether to create a new estate to add to the list, or to just replace an item within the list.
        Boolean createNew;
        //Flag which tells the program wether the estates have been saved yet, or not, so when the user uses the "Save" function it acts as "Save as ..."
        Boolean newFile;

        string currentSaveFilePath;

        // Main method.
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            currentSaveFilePath = "";
            Estates = new EstateManager();
            newFile = true;
            UpdateEstateList();
        }

        //Initialize values and lists to more easily change values later
        private void InitializeForm()
        {
            selectedEstate = -1;
            createNew = false;
            EstateInfoBoxes = new TextBox[7];
            EstateInfoBoxes[0] = this.EstateId;
            EstateInfoBoxes[1] = this.EstateStreet;
            EstateInfoBoxes[2] = this.EstateZip;
            EstateInfoBoxes[3] = this.EstateCity;
            EstateInfoBoxes[4] = this.EstateRent;
            EstateInfoBoxes[5] = this.EstateSqrft;
            EstateInfoBoxes[6] = this.UniqueEstateValue;
        }

        //Enable/disable writing in info boxes when an estate has been selected/edited.
        private void EnableInfoBoxes(bool _b)
        {
            for (int i = 0; i < EstateInfoBoxes.Length; i++)
            {
                EstateInfoBoxes[i].ReadOnly = !_b;
            }
            this.EstateTypeMenu.Enabled = _b;
            this.EstateCountryMenu.Enabled = _b;
            this.EstateUpdateButton.Enabled = _b;
            this.ImageUpload.Enabled = _b;
            this.DeleteButton.Enabled = _b;
        }

        //Update the estate list. Triggered when program starts and when information has been updated. Also triggered when search parameters change.
        private void UpdateEstateList()
        {
            String street = this.SearchBarStreet.Text;

            string zip = "";

            if (SearchBarZip.Text != null)
            {
                zip = this.SearchBarZip.Text;
            }
            String city = this.SearchBarCity.Text;
            String country = "";
            if (this.SearchBoxCountry.SelectedIndex > 0)
            {
                country = this.SearchBoxCountry.Text;

            }
            String legal = "";
            if (this.SearchBoxLegal.SelectedIndex > 0)
            {
                legal = this.SearchBoxLegal.Text;
            }
            String type = "";
            if (this.SearchBoxType.SelectedIndex > 0)
            {
                type = this.SearchBoxType.Text;
            }


            EstateList.Items.Clear();
            EstateListItems = new LinkedList<string>();

            String[] listItems = Estates.FilterEstates(street, zip, city, country, type, legal, EstateSqrftSlider.Value, EstateRentSlider.Value);



            //This for-loop goes through every Estate in the list of Estates and checks wether the filter-attributes correspond to the attributes of the estate.
            //If they do they are added to the list, if not they are hidden from view.
            for (int i = 0; i < listItems.Count(); i++)
            {
                if (listItems[i] != null)
                {
                    EstateListItems.AddLast(listItems[i]);
                    EstateList.Items.AddRange(new Object[]
                    {
                        EstateListItems.Last()
                    });
                }
                else
                {
                    break;
                }


            }
            if (Estates.Count == 0)
            {
                DeleteButton.Enabled = false;
            }
            else
            {
                DeleteButton.Enabled = true;
            }

            int hiddenCount =  Estates.Count - EstateList.Items.Count;
            //Shows the user how many Estates are hidden from the list, so there's no confusion.
            NumberOfHiddenItems.Text = hiddenCount + " hidden items";
            //Resets the selected estate, because the order of estates have been shifted around.
            selectedEstate = -1;
            EnableInfoBoxes(false);
        }

        //Update an Estate within the Estate list by creating a new one and replacing it, creates a new estate by adding it to the lists.
        private void EstateUpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                Estate res = null;
                int id = -1;
                int zip = -1;
                int rent = -1;
                int sqrft = -1;
                Address a = null;

                try
                {
                    //Checks wether the ID is unique, or the currently selected estate has the same ID. If not it throws an InvalidIDException.
                    id = VariablesCheck.AddNewId(this.EstateId.Text, ListManip.GetEstateFromList(EstateList.SelectedIndex, EstateListItems.ToArray(), Estates), Estates);
                }
                catch (DuplicateIDException)
                {
                    //Informs the user of the issue.
                    this.EditInfo.Text = "ID cannot be a duplicate. Changes not saved.";
                    throw new DuplicateIDException();
                }
                catch (StringNotIntException)
                {
                    //Informs the user that an ID must only contain numbers.
                    this.EditInfo.Text = "ID must only contain numbers 0 to 9";
                    throw new StringNotIntException();
                }

                try
                {
                    //Checks wether the ZIP contains only numbers.
                    zip = VariablesCheck.CheckIfNumberFieldHasLetters(this.EstateZip.Text);
                }
                catch (StringNotIntException)
                {
                    //Informs the user that a ZIP must only contain numbers.
                    this.EditInfo.Text = "Zip must only contain numbers 0 to 9";
                    throw new StringNotIntException();
                }

                try
                {
                    //Checks wether the rent contains only numbers.
                    rent = VariablesCheck.CheckIfNumberFieldHasLetters(this.EstateRent.Text);
                }
                catch (StringNotIntException)
                {
                    //Informs the user that rent must only contain numbers.
                    this.EditInfo.Text = "Rent must only contain numbers 0 to 9";
                    throw new StringNotIntException();
                }
                try
                {
                    //Checks wether the Square Feet attribute only contains numbers.
                    sqrft = VariablesCheck.CheckIfNumberFieldHasLetters(this.EstateSqrft.Text);
                }
                catch (StringNotIntException)
                {
                    //INforms the user that Square Feet must only contain numbers.
                    this.EditInfo.Text = "Square Feet must only contain numbers 0 to 9";
                    throw new StringNotIntException();
                }
                try
                {
                    //Attempts to create a new Address attribute. If Street address contains any special characters the constructor throws a SpecialCharException.
                    //If the City contains anything other than letters the constructor throws a SpecialCharException.
                    a = new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, EstateUtils.parseCountry(this.EstateCountryMenu.Text));
                }
                catch (SpecialCharException)
                {
                    //Informs the user that Street can only contain numbers and letters, and City can only contain letters.
                    this.EditInfo.Text = "Street address must only contain letters A-Ö and numbers 0 to 9. And City can only contain letters A-Ö.";
                }
                //Saves the path and name of the selected image to a new variable.
                string imageLocation = this.DisplayImage.ImageLocation;

                //Checks wether the estate type is either Shop or Warehouse.
                if (EstateTypeMenu.Text == Estate.EstateType.Shop.ToString() || EstateTypeMenu.Text == Estate.EstateType.Warehouse.ToString())
                {
                    //Shop and Warehouse can't be of the legal type Tenement.
                    if (EstateLegalMenu.Text == Estate.Legal.Tenement.ToString())
                    {
                        //Informs the user of the issue mentioned above.
                        this.EditInfo.Text = "Shops and Warehouses can't have Tenement as legal type.";
                        throw new Exception();
                    }
                }

                //Depending on the type of estate the program creates different estates.
                if (this.EstateTypeMenu.Text == Estate.EstateType.House.ToString())
                {
                    int val = VariablesCheck.CheckIfNumberFieldHasLetters(UniqueEstateValue.Text);
                    res = new House(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, EstateUtils.parseCountry(this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation, val);
                }
                else if (EstateTypeMenu.Text == Estate.EstateType.Apartment.ToString())
                {
                    int val = VariablesCheck.CheckIfNumberFieldHasLetters(UniqueEstateValue.Text);
                    res = new Apartment(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, EstateUtils.parseCountry(this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation, val);
                }
                else if (EstateTypeMenu.Text == Estate.EstateType.Villa.ToString())
                {
                    int val = VariablesCheck.CheckIfNumberFieldHasLetters(UniqueEstateValue.Text);
                    res = new Villa(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, EstateUtils.parseCountry(this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation, val);
                }
                else if (EstateTypeMenu.Text == Estate.EstateType.Rowhouse.ToString())
                {
                    int val = VariablesCheck.CheckIfNumberFieldHasLetters(UniqueEstateValue.Text);
                    res = new Rowhouse(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, EstateUtils.parseCountry(this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation, val);
                }
                else if (EstateTypeMenu.Text == Estate.EstateType.Shop.ToString())
                {
                    int val = VariablesCheck.CheckIfNumberFieldHasLetters(UniqueEstateValue.Text);
                    res = new Shop(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, EstateUtils.parseCountry(this.EstateCountryMenu.Text)), (Commercial.Legal)Enum.Parse(typeof(Commercial.Legal), this.EstateLegalMenu.Text), imageLocation, val);
                }
                else if (EstateTypeMenu.Text == Estate.EstateType.Warehouse.ToString())
                {
                    bool val = VariablesCheck.checkTrueFalse(UniqueEstateValue.Text);
                    res = new Warehouse(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, EstateUtils.parseCountry(this.EstateCountryMenu.Text)), (Commercial.Legal)Enum.Parse(typeof(Commercial.Legal), this.EstateLegalMenu.Text), imageLocation, val);
                }

                //If the boolean createnew is set to false then the new estate replaces the selected item in the list.
                //If not, then it creates a new estate and adds it to the top of the list.
                if (!createNew)
                {
                    Estates.ChangeAt(res, selectedEstate);
                    EditInfo.Text = "Estate edited succesfully!";
                }
                else
                {
                    Estates.Add(res);
                    selectedEstate = 0;

                    EditInfo.Text = "Estate created succesfully!";
                    this.EstateUpdateButton.Text = "Update info";
                    createNew = false;
                }
                UpdateEstateList();
            }
            catch (Exception _e)
            {
                Console.WriteLine(_e);
            }

        }

        //Update Estate text boxes with appropriate values from the selected Estate.
        private void EstateList_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableInfoBoxes(true);
            this.EstateUpdateButton.Text = "Update info";
            this.EditInfo.Text = "Ready to edit";
            createNew = false;
            try
            {
                ListBox listbox = (ListBox)sender;
                Estate building = ListManip.GetEstateFromList(listbox.SelectedIndex, EstateListItems.ToArray(), Estates);
                selectedEstate = ListManip.GetEstateSearchListPositionByEstateID(building.Id, Estates);
                this.EstateId.Text = building.Id.ToString();
                this.EstateStreet.Text = building.Address.Street.ToString();
                this.EstateZip.Text = building.Address.Zip.ToString();
                this.EstateCity.Text = building.Address.City;

                this.EstateLegalMenu.SelectedItem = building.GetLegalType();
                this.EstateTypeMenu.SelectedItem = building.type.ToString();

                UpdateImage(building.Image);
                this.EstateRent.Text = building.Rent.ToString();
                this.EstateSqrft.Text = building.Sqrft.ToString();
                this.EstateCountryMenu.SelectedItem = building.Address.country.ToString();
                changeUniqueValueTextBox();
                switch (building.type) 
                {
                    case Estate.EstateType.Apartment:
                        Apartment apt = (Apartment)building;
                        UniqueEstateValue.Text = apt.floor.ToString();
                        break;
                    case Estate.EstateType.House:
                        House hs = (House)building;
                        UniqueEstateValue.Text = hs.bathrooms.ToString();
                        break;
                    case Estate.EstateType.Rowhouse:
                        Rowhouse rh = (Rowhouse)building;
                        UniqueEstateValue.Text = rh.balconies.ToString();
                        break;
                    case Estate.EstateType.Shop:
                        Shop sp = (Shop)building;
                        UniqueEstateValue.Text = sp.maxNumberOfShoppers.ToString();
                        break;
                    case Estate.EstateType.Villa:
                        Villa vl = (Villa)building;
                        UniqueEstateValue.Text = vl.sqrftGarden.ToString();
                        break;
                    case Estate.EstateType.Warehouse:
                        Warehouse wh = (Warehouse)building;
                        UniqueEstateValue.Text = wh.HasDedicatedGuard.ToString();
                        break;
                }
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine(exc);
            }
        }
        //Button for creating a new residential estate.
        private void NewResidenceButton_Click(object sender, EventArgs e)
        {
            CreateNewEstate();
        }
        //Button for creating a new Commercial estate.

        //Button for creating a new estate and adding it to the list of estates.
        //Takes values from the textboxes in the edit field and uses them to create a new estate.
        //Clicking on another estate item will discard the new estate if it hasn't been created.
        private void CreateNewEstate()
        {
            createNew = true;
            EnableInfoBoxes(true);
            this.EstateUpdateButton.Text = "Create new";
            this.EditInfo.Text = "Create new";
            try
            {
                this.EstateId.Text = "";
                this.EstateStreet.Text = "";
                this.EstateZip.Text = "";
                this.EstateCity.Text = "";
                this.EstateRent.Text = "";
                this.EstateSqrft.Text = "";
                this.EstateTypeMenu.SelectedIndex = 0;
                this.EstateLegalMenu.SelectedIndex = 0;
                this.DisplayImage.Image = null;
                this.DisplayImage.ImageLocation = null;
                this.EstateCountryMenu.SelectedItem = "Sverige";
                this.UniqueEstateValue.Text = "";
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine(exc);
            }
        }

        //Update the image, either with an existing file, or with a null.
        private void UpdateImage(string fileName)
        {
            if (fileName != null)
            {
                this.DisplayImage.SizeMode = PictureBoxSizeMode.StretchImage;
                this.DisplayImage.ImageLocation = fileName;
                this.DisplayImage.Image = (Image)new Bitmap(fileName);
            }
            else
            {
                this.DisplayImage.Image = null;
            }
        }

        //When you click the image upload button you are prompted to select a JPG or PNG image.
        //The address of the file is saved, and the address is converted into a Bitmap (if there is an image)
        private void ImageUpload_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images";
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = projectDirectory,
                RestoreDirectory = true,
                Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png",
                ReadOnlyChecked = true,
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                UpdateImage(ofd.FileName);
            }
        }

        //Delete the selected estate
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Estates.DeleteEstate(ListManip.GetEstateByID(ListManip.GetEstateIdFromEstateSearchList(EstateListItems.ElementAt(selectedEstate)), Estates));
            selectedEstate = -1;
            UpdateEstateList();
            EnableInfoBoxes(false);
        }


        //Search tools. With each action on the search tools the list is updated with the new parameters.
        private void SearchBarStreet_TextChanged(object sender, EventArgs e)
        {
            UpdateEstateList();
        }

        private void SearchBarZip_TextChanged(object sender, EventArgs e)
        {
            UpdateEstateList();
        }

        private void SearchBarCity_TextChanged(object sender, EventArgs e)
        {
            UpdateEstateList();
        }

        private void SearchBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEstateList();
        }

        private void SearchBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEstateList();
        }

        private void SearchBoxLegal_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEstateList();
        }

        private void EstateRentSlider_Scroll(object sender, EventArgs e)
        {
            SearchRentDisplay.Text = EstateRentSlider.Value.ToString();
            UpdateEstateList();
        }

        private void EstateSqrftSlider_Scroll(object sender, EventArgs e)
        {
            SearchSqrftDisplay.Text = EstateSqrftSlider.Value.ToString();
            UpdateEstateList();
        }

        // File Menu functions
        private void mnuNew_Click(object sender, EventArgs e)
        {
            newFile = true;
            Estates.DeleteAll();
            UpdateEstateList();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (newFile)
            {
                mnuFileSaveAs_Click(sender, e);
            }
            else
            {
                Estates.BinarySerialize(currentSaveFilePath);
            }
        }



        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\DataFiles\\";
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = projectDirectory,
                RestoreDirectory = true,
                Filter = "TXT files (*.txt)|*.txt",
                ReadOnlyChecked = true,
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Estates.BinaryDeSerialize(ofd.FileName);
                foreach(Estate estate in Estates.ToList())
                {
                    Estates.GetCountryDictionary().Add(estate);
                }
                UpdateEstateList();
            }
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            if (Estates.Count == 0)
            {
                MessageBox.Show("Can't save an empty project");
                return;
            }
            else
            {
                var ofd = new SaveFileDialog();
                ofd.Filter = "TXT files (*.txt)|*.txt";
                ofd.RestoreDirectory = true;
                ofd.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\DataFiles\\";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Estates.BinarySerialize(ofd.FileName);
                    currentSaveFilePath = ofd.FileName;
                }
            }

            newFile = false;
        }

        private void mnuXMLImport_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\DataFiles\\";
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = projectDirectory,
                RestoreDirectory = true,
                Filter = "XML files (*.xml)|*.xml",
                ReadOnlyChecked = true,
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Estates.xmlDeSerialize(ofd.FileName);
                foreach (Estate estate in Estates.ToList())
                {
                    Estates.GetCountryDictionary().Add(estate);
                }
                UpdateEstateList();
            }
        }

        private void mnuXMLExport_Click(object sender, EventArgs e)
        {
            if (Estates.Count == 0)
            {
                MessageBox.Show("Can't save an empty project");
                return;
            }

            var ofd = new SaveFileDialog();
            ofd.Filter = "XML files (*.xml)|*.xml";
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\DataFiles\\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Estates.XMLSerialize(ofd.FileName);
            }
        }

        private void changeUniqueValueTextBox()
        {
            switch (EstateTypeMenu.SelectedItem)
            {
                case "Apartment":
                    UniqueEstateValueText.Text = "Floor";
                    break;
                case "House":
                    UniqueEstateValueText.Text = "Number of Bathrooms";
                    break;
                case "Rowhouse":
                    UniqueEstateValueText.Text = "Number of balconies";
                    break;
                case "Shop":
                    UniqueEstateValueText.Text = "Maximum number of shoppers";
                    break;
                case "Villa":
                    UniqueEstateValueText.Text = "Square feet of garden";
                    break;
                case "Warehouse":
                    UniqueEstateValueText.Text = "Warehouse has a security guard (true/false)";
                    break;
                default:
                    UniqueEstateValueText.Text = "Unique estate value text";
                    break;
            }
            UniqueEstateValue.Text = "";
        }

        private void EstateTypeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeUniqueValueTextBox();
        }
    }
}
