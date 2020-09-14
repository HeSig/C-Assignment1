using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        LinkedList<Estate> Estates;
        TextBox[] EstateInfoBoxes;
        LinkedList<string> EstateListItems;
        String NewResidentialType;
        int selectedEstate;
        Boolean createNew;
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            Estates = new LinkedList<Estate>();

            Estates.AddLast(new Residential(1, 23, 2000, new Address("Storgatan 2", 32736, "Malmö", Buildings.Countries.Sverige), Residential.Legal.Rental, Residential.EstateType.Apartment, null));
            Estates.AddLast(new Residential(2, 23, 2000, new Address("Storgatan 3", 22336, "Lund", Buildings.Countries.Sverige), Residential.Legal.Tenement, Residential.EstateType.Apartment, null));

            UpdateEstateList();
        }

        //Initialize values and lists to more easily change values later
        private void InitializeForm()
        {
            selectedEstate = -1;
            createNew = false;
            EstateInfoBoxes = new TextBox[6];
            EstateInfoBoxes[0] = this.EstateId;
            EstateInfoBoxes[1] = this.EstateStreet;
            EstateInfoBoxes[2] = this.EstateZip;
            EstateInfoBoxes[3] = this.EstateCity;
            //EstateInfoBoxes[4] = this.EstateCategory;
            EstateInfoBoxes[4] = this.EstateRent;
            EstateInfoBoxes[5] = this.EstateSqrft;
        }

        //Enable writing in info boxes when an estate has been selected
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
        // TODO: Filter Estates to add to list by the parameters within the search boxes
        private void UpdateEstateList()
        {
            String street = this.SearchBarStreet.Text;
            string zip = "";
            if (SearchBarZip.Text != null) { 
                zip = this.SearchBarZip.Text;
            }
            String city = this.SearchBarCity.Text;
            String country = "";
            if(this.SearchBoxCountry.SelectedIndex != 0) { 
                country = this.SearchBoxCountry.Text;
            }
            String legal = "";
            if(this.SearchBoxLegal.SelectedIndex != 0)
            {
                legal = this.SearchBoxLegal.Text;
            }
            String type = "";
            if(this.SearchBoxType.SelectedIndex != 0)
            {
                type = this.SearchBoxType.Text;
            }


            EstateList.Items.Clear();
            EstateListItems = new LinkedList<string>();
            for (int i = 0; i < Estates.Count; i++)
            {
                Estate e = Estates.ElementAt(i);
                if(e.Address.Street.Contains(street) && e.Address.Zip.ToString().Contains(zip) && e.Address.City.Contains(city) && e.Address.country.ToString().Contains(country) && e.GetEstateType().Contains(type) && e.GetLegalType().Contains(legal)){ 
                    EstateListItems.AddLast($"{e.Id} : {e.Address.Street} {e.Address.City} {e.Address.country}");
                    EstateList.Items.AddRange(new Object[]
                    {
                        EstateListItems.Last()
                    });
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
            selectedEstate = -1;
            EnableInfoBoxes(false);
        }

        //Update an Estate within the Estate list by creating a new one and replacing it.
        private void EstateUpdateButtonClick(object sender, EventArgs e)
        {
            try
            {
                //Estate estate = Estates.ElementAt(selectedEstate);
                Estate res;
                int id = -1;
                int zip = -1;
                int rent = -1;
                int sqrft = -1;
                Address a = null;
                try {
                    id = Forms.VariablesCheck.AddNewId(this.EstateId.Text, Forms.ListManip.GetEstateFromList(selectedEstate,EstateListItems.ToArray(), Estates.ToArray()), Estates.ToArray());
                }
                catch (Forms.DuplicateIDException)
                {
                    this.EditInfo.Text = "ID cannot be a duplicate. Changes not saved.";
                    throw new Forms.DuplicateIDException();
                }
                catch (Forms.StringNotIntException)
                {
                    this.EditInfo.Text = "ID must only contain numbers 0 to 9";
                    throw new Forms.StringNotIntException();
                }

                try
                {
                    zip = Forms.VariablesCheck.CheckIfNumberFieldHasLetters(this.EstateZip.Text);
                }
                catch (Forms.StringNotIntException)
                {
                    this.EditInfo.Text = "Zip must only contain numbers 0 to 9";
                    throw new Forms.StringNotIntException();
                }

                try
                {
                    rent = Forms.VariablesCheck.CheckIfNumberFieldHasLetters(this.EstateRent.Text);
                }
                catch (Forms.StringNotIntException)
                {
                    this.EditInfo.Text = "Rent must only contain numbers 0 to 9";
                    throw new Forms.StringNotIntException();
                }
                try
                {
                    sqrft = Forms.VariablesCheck.CheckIfNumberFieldHasLetters(this.EstateSqrft.Text);
                }
                catch (Forms.StringNotIntException)
                {
                    this.EditInfo.Text = "Square Feet must only contain numbers 0 to 9";
                    throw new Forms.StringNotIntException();
                }

                try
                {
                    a = new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text));
                }
                catch (Buildings.SpecialCharException)
                {
                    this.EditInfo.Text = "Street address must only contain letters A-Ö and numbers 0 to 9. And City can only contain letters A-Ö.";
                }

                string imageLocation = this.DisplayImage.ImageLocation;
                if (this.EstateCategory.Text == "Residential")
                {
                    res = new Residential(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), (Residential.EstateType)Enum.Parse(typeof(Residential.EstateType), this.EstateTypeMenu.Text), imageLocation);
                }
                else
                {
                    res = new Commercial(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Commercial.Legal)Enum.Parse(typeof(Commercial.Legal), this.EstateLegalMenu.Text), (Commercial.EstateType)Enum.Parse(typeof(Commercial.EstateType), this.EstateTypeMenu.Text), imageLocation);
                }
                if (!createNew) { 
                    Estates.Find(Estates.ElementAt(selectedEstate)).Value = res;
                    EditInfo.Text = "Estate edited succesfully!";
                }
                else
                {
                    Estates.AddFirst(res);
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
                Estate building = Forms.ListManip.GetEstateFromList(listbox.SelectedIndex, EstateListItems.ToArray(), Estates.ToArray());
                selectedEstate = Forms.ListManip.GetEstateSearchListPositionByEstateID(building.Id, Estates.ToArray());
                this.EstateId.Text = building.Id.ToString();
                this.EstateStreet.Text = building.Address.Street.ToString();
                this.EstateZip.Text = building.Address.Zip.ToString();
                this.EstateCity.Text = building.Address.City;
                this.EstateCategory.Text = building.Category;
                this.EstateTypeMenu.Items.Clear();
                this.EstateLegalMenu.Items.Clear();
                this.EstateLegalMenu.Items.Add("Ownership");
                this.EstateLegalMenu.Items.Add("Rental");

                switch (building.Category)
                {
                    case "Residential":
                        {
                            this.EstateTypeMenu.Items.Add("House");
                            this.EstateTypeMenu.Items.Add("Villa");
                            this.EstateTypeMenu.Items.Add("Apartment");
                            this.EstateTypeMenu.Items.Add("Rowhouse");
                            this.EstateLegalMenu.Items.Add("Tenement");
                            this.EstateLegalMenu.SelectedItem = building.GetLegalType();
                            break;
                        }
                    case "Commercial":
                        {
                            this.EstateTypeMenu.Items.Add("Shop");
                            this.EstateTypeMenu.Items.Add("Warehouse");
                            this.EstateLegalMenu.SelectedItem = building.GetLegalType();
                            break;
                        }
                }
                this.EstateTypeMenu.SelectedItem = building.GetEstateType();

                UpdateImage(building.Image);
                this.EstateRent.Text = building.Rent.ToString();
                this.EstateSqrft.Text = building.Sqrft.ToString();
                this.EstateCountryMenu.SelectedItem = building.Address.country.ToString();
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine(exc);
            }
        }

        


        // Do I need this?
        /*
        private int GetListItemFromId(int id)
        {
            string strId = id + "";
            int count = 0;
            string itemStr;
            for (int i = 0; i < EstateListItems.Count; i++)
            {
                itemStr = EstateListItems.ElementAt(i);
                for (int j = 0; j < strId.Length; i++)
                {
                    if (itemStr.ElementAt(j) != strId.ElementAt(j))
                    {
                        count = 0;
                        break;
                    }

                }
                if (count != 0)
                {
                    return i;
                }
            }
            return -1;
        }
        */

        

        //Button for creating a new residential estate.
        private void NewResidenceButton_Click(object sender, EventArgs e)
        {
            CreateNewEstate("Residential");
        }
        //Button for creating a new Commercial estate.
        private void NewCommercialButton_Click(object sender, EventArgs e)
        {

            CreateNewEstate("Commercial");
        }
        //Button for creating a new estate and adding it to the list of estates.
        //Takes values from the textboxes in the edit field and uses them to create a new estate.
        //Clicking on another estate item will discard the new estate if it hasn't been created.
        private void CreateNewEstate(String _estateType)
        {
            createNew = true;
            NewResidentialType = _estateType;
            EnableInfoBoxes(true);
            this.EstateUpdateButton.Text = "Create new " + _estateType;
            this.EditInfo.Text = "Create new";
            try
            {
                this.EstateId.Text = "";
                this.EstateStreet.Text = "";
                this.EstateZip.Text = "";
                this.EstateCity.Text = "";
                this.EstateCategory.Text = _estateType;
                this.EstateTypeMenu.Items.Clear();
                this.EstateLegalMenu.Items.Clear();
                this.EstateLegalMenu.Items.Add("Ownership");
                this.EstateLegalMenu.Items.Add("Rental");

                switch (_estateType)
                {
                    case "Residential":
                        {
                            this.EstateTypeMenu.Items.Add("House");
                            this.EstateTypeMenu.Items.Add("Villa");
                            this.EstateTypeMenu.Items.Add("Apartment");
                            this.EstateTypeMenu.Items.Add("Rowhouse");
                            this.EstateLegalMenu.Items.Add("Tenement");
                            this.EstateTypeMenu.SelectedItem = "House";
                            this.EstateLegalMenu.SelectedItem = "Ownership";
                            break;
                        }
                    case "Commercial":
                        {
                            this.EstateTypeMenu.Items.Add("Shop");
                            this.EstateTypeMenu.Items.Add("Warehouse");
                            this.EstateLegalMenu.SelectedItem = "Ownership";
                            this.EstateTypeMenu.SelectedItem = "Shop";
                            break;
                        }
                }
                this.EstateRent.Text = "";
                this.EstateSqrft.Text = "";
                this.EstateCountryMenu.SelectedItem = "Sverige";
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void UpdateImage(string fileName)
        {
            if(fileName != null) { 
                this.DisplayImage.SizeMode = PictureBoxSizeMode.StretchImage;
                this.DisplayImage.ImageLocation = fileName;
                this.DisplayImage.Image = (Image)new Bitmap(fileName);
            }
            else
            {
                this.DisplayImage.Image = null;
            }
        }

        private void ImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() {
            InitialDirectory = @"C:\",
            RestoreDirectory = true,
            Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png",
            ReadOnlyChecked = true,
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                UpdateImage(ofd.FileName);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Estates.Remove(Forms.ListManip.GetEstateByID(Forms.ListManip.GetEstateIdFromEstateSearchList(EstateListItems.ElementAt(selectedEstate)),Estates.ToArray()));
            selectedEstate = -1;
            UpdateEstateList();
            EnableInfoBoxes(false);
        }

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
    }
}
