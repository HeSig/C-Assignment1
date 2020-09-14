﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1;
using Assignment1.Buildings.BuildingTypes;
using System.IO;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        LinkedList<Estate> Estates;
        TextBox[] EstateInfoBoxes;
        LinkedList<string> EstateListItems;
        int selectedEstate;
        Boolean createNew;
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            Estates = new LinkedList<Estate>();

            Estates.AddLast(new House(1, 23, 2000, new Address("Storgatan 2", 32736, "Malmö", Buildings.Countries.Sverige), Estate.Legal.Rental, Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\House.jpg"));
            Estates.AddLast(new Villa(2, 500, 5000, new Address("Sopgatan 11", 42736, "Malmö", Buildings.Countries.Sverige), Estate.Legal.Ownership, Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\House.jpg"));
            Estates.AddLast(new Rowhouse(3, 200, 4500, new Address("Kungsvägen 12", 31536, "Malmö", Buildings.Countries.Sverige), Estate.Legal.Tenement, Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\House.jpg"));
            Estates.AddLast(new Shop(4, 150, 12000, new Address("Storgatan 3", 22336, "Lund", Buildings.Countries.Sverige), Estate.Legal.Rental, Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\Storefront.jpg"));
            Estates.AddLast(new Warehouse(5, 1000, 7000, new Address("Kung Oskars Bro 4", 22336, "Luleå", Buildings.Countries.Sverige), Estate.Legal.Ownership, Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\Storefront.jpg"));
            Estates.AddLast(new Shop(6, 100, 5000, new Address("Storgatan 3", 12412, "Göteborg", Buildings.Countries.Sverige), Estate.Legal.Ownership, Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\Storefront.jpg"));
            Estates.AddLast(new Warehouse(7, 250, 2000, new Address("Möllan 4", 53135, "Malmö", Buildings.Countries.Sverige), Estate.Legal.Rental, Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images\\Storefront.jpg"));

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
        private void UpdateEstateList()
        {
            String street = this.SearchBarStreet.Text;
            string zip = "";
            int hiddenCount = 0;
            if (SearchBarZip.Text != null)
            {
                zip = this.SearchBarZip.Text;
            }
            String city = this.SearchBarCity.Text;
            String country = "";
            if (this.SearchBoxCountry.SelectedIndex != 0)
            {
                country = this.SearchBoxCountry.Text;
            }
            String legal = "";
            if (this.SearchBoxLegal.SelectedIndex != 0)
            {
                legal = this.SearchBoxLegal.Text;
            }
            String type = "";
            if (this.SearchBoxType.SelectedIndex != 0)
            {
                type = this.SearchBoxType.Text;
            }


            EstateList.Items.Clear();
            EstateListItems = new LinkedList<string>();
            for (int i = 0; i < Estates.Count; i++)
            {
                Estate e = Estates.ElementAt(i);
                if (e.Address.Street.ToLower().Contains(street.ToLower()) && e.Address.Zip.ToString().Contains(zip) && e.Address.City.ToLower().Contains(city.ToLower()) && e.Address.country.ToString().Contains(country) && e.GetEstateType().Contains(type) && e.GetLegalType().Contains(legal) && e.Sqrft >= EstateSqrftSlider.Value && e.Rent <= EstateRentSlider.Value)
                {
                    EstateListItems.AddLast($"{e.Id} : {e.Address.Street} {e.Address.City} {e.Address.country}");
                    EstateList.Items.AddRange(new Object[]
                    {
                        EstateListItems.Last()
                    });
                }
                else
                {
                    hiddenCount++;
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
            NumberOfHiddenItems.Text = hiddenCount + " hidden items";
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
                    id = Forms.VariablesCheck.AddNewId(this.EstateId.Text, Forms.ListManip.GetEstateFromList(selectedEstate, EstateListItems.ToArray(), Estates.ToArray()), Estates.ToArray());
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

                if(EstateTypeMenu.Text == "Shop" || EstateTypeMenu.Text == "Warehouse")
                {
                    if (EstateLegalMenu.Text == "Tenement")
                    {
                        this.EditInfo.Text = "Shops and Warehouses cant have Tenement as legal type.";
                        throw new Exception();
                    }
                }

                //Depending on the type of estate the program creates different estates.
                if (this.EstateTypeMenu.Text == "House")
                {
                    res = new House(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation);
                }
                else if (EstateTypeMenu.Text == "Apartment")
                {
                    res = new Apartment(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation);
                }
                else if (EstateTypeMenu.Text == "Villa")
                {
                    res = new Villa(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation);
                }
                else if (EstateTypeMenu.Text == "Rowhouse")
                {
                    res = new Rowhouse(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Residential.Legal)Enum.Parse(typeof(Residential.Legal), this.EstateLegalMenu.Text), imageLocation);
                }
                else if (EstateTypeMenu.Text == "Shop")
                {
                    res = new Shop(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Commercial.Legal)Enum.Parse(typeof(Commercial.Legal), this.EstateLegalMenu.Text), imageLocation);
                }
                else if (EstateTypeMenu.Text == "Warehouse")
                {
                    res = new Warehouse(id, sqrft, rent, new Address(this.EstateStreet.Text, zip, this.EstateCity.Text, (Buildings.Countries)Enum.Parse(typeof(Buildings.Countries), this.EstateCountryMenu.Text)), (Commercial.Legal)Enum.Parse(typeof(Commercial.Legal), this.EstateLegalMenu.Text), imageLocation);
                }

                //If the boolean createnew is set to false then the new estate replaces the selected item in the list.
                //If not, then it creates a new estate and adds it to the top of the list.
                if (!createNew)
                {
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

                this.EstateLegalMenu.SelectedItem = building.GetLegalType();
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
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine(exc);
            }
        }

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

        private void ImageUpload_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Images";
            OpenFileDialog ofd = new OpenFileDialog()
            {
                //InitialDirectory = @"C:\",
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Estates.Remove(Forms.ListManip.GetEstateByID(Forms.ListManip.GetEstateIdFromEstateSearchList(EstateListItems.ElementAt(selectedEstate)), Estates.ToArray()));
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
    }
}
