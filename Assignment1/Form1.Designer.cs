using System;

namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NumberOfHiddenItems = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SearchSqrftDisplay = new System.Windows.Forms.TextBox();
            this.SearchRentDisplay = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchBoxLegal = new System.Windows.Forms.ComboBox();
            this.SearchBoxType = new System.Windows.Forms.ComboBox();
            this.SearchBoxCountry = new System.Windows.Forms.ComboBox();
            this.SearchBarCity = new System.Windows.Forms.TextBox();
            this.SearchBarZip = new System.Windows.Forms.TextBox();
            this.SearchBarStreet = new System.Windows.Forms.TextBox();
            this.RentPriceSliderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Thousand1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RentPriceSliderLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EstateSqrftSlider = new System.Windows.Forms.TrackBar();
            this.EstateRentSlider = new System.Windows.Forms.TrackBar();
            this.NewResidenceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ImageUpload = new System.Windows.Forms.Button();
            this.EstateLegalMenu = new System.Windows.Forms.ComboBox();
            this.EstateTypeMenu = new System.Windows.Forms.ComboBox();
            this.EstateCountryMenu = new System.Windows.Forms.ComboBox();
            this.EditInfo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstateUpdateButton = new System.Windows.Forms.Button();
            this.SqrftLabel = new System.Windows.Forms.Label();
            this.RentLabel = new System.Windows.Forms.Label();
            this.EstateRent = new System.Windows.Forms.TextBox();
            this.EstateSqrft = new System.Windows.Forms.TextBox();
            this.EstateCity = new System.Windows.Forms.TextBox();
            this.EstateZip = new System.Windows.Forms.TextBox();
            this.EstateStreet = new System.Windows.Forms.TextBox();
            this.EstateId = new System.Windows.Forms.TextBox();
            this.DisplayImage = new System.Windows.Forms.PictureBox();
            this.EstateList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXMLImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXMLExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstateSqrftSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstateRentSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumberOfHiddenItems);
            this.tabPage1.Controls.Add(this.SearchGroupBox);
            this.tabPage1.Controls.Add(this.NewResidenceButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.EstateList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "House List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NumberOfHiddenItems
            // 
            this.NumberOfHiddenItems.AutoSize = true;
            this.NumberOfHiddenItems.Location = new System.Drawing.Point(3, 209);
            this.NumberOfHiddenItems.Name = "NumberOfHiddenItems";
            this.NumberOfHiddenItems.Size = new System.Drawing.Size(75, 13);
            this.NumberOfHiddenItems.TabIndex = 32;
            this.NumberOfHiddenItems.Text = "0 hidden items";
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.label16);
            this.SearchGroupBox.Controls.Add(this.label15);
            this.SearchGroupBox.Controls.Add(this.SearchSqrftDisplay);
            this.SearchGroupBox.Controls.Add(this.SearchRentDisplay);
            this.SearchGroupBox.Controls.Add(this.label14);
            this.SearchGroupBox.Controls.Add(this.label13);
            this.SearchGroupBox.Controls.Add(this.label12);
            this.SearchGroupBox.Controls.Add(this.SearchBoxLegal);
            this.SearchGroupBox.Controls.Add(this.SearchBoxType);
            this.SearchGroupBox.Controls.Add(this.SearchBoxCountry);
            this.SearchGroupBox.Controls.Add(this.SearchBarCity);
            this.SearchGroupBox.Controls.Add(this.SearchBarZip);
            this.SearchGroupBox.Controls.Add(this.SearchBarStreet);
            this.SearchGroupBox.Controls.Add(this.RentPriceSliderLabel);
            this.SearchGroupBox.Controls.Add(this.label1);
            this.SearchGroupBox.Controls.Add(this.Thousand1);
            this.SearchGroupBox.Controls.Add(this.label2);
            this.SearchGroupBox.Controls.Add(this.RentPriceSliderLabel2);
            this.SearchGroupBox.Controls.Add(this.label3);
            this.SearchGroupBox.Controls.Add(this.EstateSqrftSlider);
            this.SearchGroupBox.Controls.Add(this.EstateRentSlider);
            this.SearchGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(348, 195);
            this.SearchGroupBox.TabIndex = 27;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search tools";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Sqr feet";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Kr/Month";
            // 
            // SearchSqrftDisplay
            // 
            this.SearchSqrftDisplay.Location = new System.Drawing.Point(213, 169);
            this.SearchSqrftDisplay.Name = "SearchSqrftDisplay";
            this.SearchSqrftDisplay.ReadOnly = true;
            this.SearchSqrftDisplay.Size = new System.Drawing.Size(43, 20);
            this.SearchSqrftDisplay.TabIndex = 29;
            this.SearchSqrftDisplay.Text = "10";
            // 
            // SearchRentDisplay
            // 
            this.SearchRentDisplay.Location = new System.Drawing.Point(54, 169);
            this.SearchRentDisplay.Name = "SearchRentDisplay";
            this.SearchRentDisplay.ReadOnly = true;
            this.SearchRentDisplay.Size = new System.Drawing.Size(39, 20);
            this.SearchRentDisplay.TabIndex = 28;
            this.SearchRentDisplay.Text = "15000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "City";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Street";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Zip Code";
            // 
            // SearchBoxLegal
            // 
            this.SearchBoxLegal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBoxLegal.FormattingEnabled = true;
            this.SearchBoxLegal.Items.AddRange(new object[] {
            "Any Legal Type",
            "Ownership",
            "Rental",
            "Tenement"});
            this.SearchBoxLegal.Location = new System.Drawing.Point(171, 71);
            this.SearchBoxLegal.Name = "SearchBoxLegal";
            this.SearchBoxLegal.Size = new System.Drawing.Size(159, 21);
            this.SearchBoxLegal.TabIndex = 27;
            this.SearchBoxLegal.SelectedIndexChanged += new System.EventHandler(this.SearchBoxLegal_SelectedIndexChanged);
            // 
            // SearchBoxType
            // 
            this.SearchBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBoxType.FormattingEnabled = true;
            this.SearchBoxType.Items.AddRange(new object[] {
            "Any Building Type",
            "House",
            "Apartment",
            "Villa",
            "Shop",
            "Rowhouse",
            "Warehouse"});
            this.SearchBoxType.Location = new System.Drawing.Point(171, 45);
            this.SearchBoxType.Name = "SearchBoxType";
            this.SearchBoxType.Size = new System.Drawing.Size(159, 21);
            this.SearchBoxType.TabIndex = 26;
            this.SearchBoxType.SelectedIndexChanged += new System.EventHandler(this.SearchBoxType_SelectedIndexChanged);
            // 
            // SearchBoxCountry
            // 
            this.SearchBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBoxCountry.FormattingEnabled = true;
            this.SearchBoxCountry.Items.AddRange(new object[] {
            "Any Country",
            "Afghanistan",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua_and_Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia_and_Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina_Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape_Verde",
            "Central_African_Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Democratic_Republic_of_the_Congo",
            "Costa_Rica",
            "Côte_d_Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech_Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican_Republic",
            "East_Timor_or_Timur",
            "Ecuador",
            "Egypt",
            "El_Salvador",
            "Equatorial_Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea_Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea_North",
            "Korea_South",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall_Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia_Federated_States_of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New_Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua_New_Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint_Kitts_and_Nevis",
            "Saint_Lucia",
            "Saint_Vincent_and_The_Grenadines",
            "Samoa",
            "San_Marino",
            "Sao_Tome_and_Principe",
            "Saudi_Arabia",
            "Senegal",
            "Serbia_and_Montenegro",
            "Seychelles",
            "Sierra_Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon_Islands",
            "Somalia",
            "South_Africa",
            "Spain",
            "Sri_Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sverige",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad_and_Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United_Arab_Emirates",
            "United_Kingdom",
            "United_States_of_America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican_City",
            "Venezuela",
            "Vietnam",
            "Western_Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.SearchBoxCountry.Location = new System.Drawing.Point(171, 18);
            this.SearchBoxCountry.Name = "SearchBoxCountry";
            this.SearchBoxCountry.Size = new System.Drawing.Size(159, 21);
            this.SearchBoxCountry.TabIndex = 25;
            this.SearchBoxCountry.SelectedIndex = 0;
            this.SearchBoxCountry.SelectedIndexChanged += new System.EventHandler(this.SearchBoxCountry_SelectedIndexChanged);
            // 
            // SearchBarCity
            // 
            this.SearchBarCity.Location = new System.Drawing.Point(54, 71);
            this.SearchBarCity.Name = "SearchBarCity";
            this.SearchBarCity.Size = new System.Drawing.Size(100, 20);
            this.SearchBarCity.TabIndex = 14;
            this.SearchBarCity.TextChanged += new System.EventHandler(this.SearchBarCity_TextChanged);
            // 
            // SearchBarZip
            // 
            this.SearchBarZip.Location = new System.Drawing.Point(54, 45);
            this.SearchBarZip.Name = "SearchBarZip";
            this.SearchBarZip.Size = new System.Drawing.Size(100, 20);
            this.SearchBarZip.TabIndex = 13;
            this.SearchBarZip.TextChanged += new System.EventHandler(this.SearchBarZip_TextChanged);
            // 
            // SearchBarStreet
            // 
            this.SearchBarStreet.Location = new System.Drawing.Point(54, 19);
            this.SearchBarStreet.Name = "SearchBarStreet";
            this.SearchBarStreet.Size = new System.Drawing.Size(100, 20);
            this.SearchBarStreet.TabIndex = 12;
            this.SearchBarStreet.TextChanged += new System.EventHandler(this.SearchBarStreet_TextChanged);
            // 
            // RentPriceSliderLabel
            // 
            this.RentPriceSliderLabel.AutoSize = true;
            this.RentPriceSliderLabel.Location = new System.Drawing.Point(2, 105);
            this.RentPriceSliderLabel.Name = "RentPriceSliderLabel";
            this.RentPriceSliderLabel.Size = new System.Drawing.Size(103, 13);
            this.RentPriceSliderLabel.TabIndex = 5;
            this.RentPriceSliderLabel.Text = "Rent price Maximum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(282, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "2000 |";
            // 
            // Thousand1
            // 
            this.Thousand1.AutoSize = true;
            this.Thousand1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Thousand1.Location = new System.Drawing.Point(11, 147);
            this.Thousand1.Name = "Thousand1";
            this.Thousand1.Size = new System.Drawing.Size(48, 13);
            this.Thousand1.TabIndex = 6;
            this.Thousand1.Text = "| 1000 kr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(178, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "| 10";
            // 
            // RentPriceSliderLabel2
            // 
            this.RentPriceSliderLabel2.AutoSize = true;
            this.RentPriceSliderLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RentPriceSliderLabel2.Location = new System.Drawing.Point(100, 147);
            this.RentPriceSliderLabel2.Name = "RentPriceSliderLabel2";
            this.RentPriceSliderLabel2.Size = new System.Drawing.Size(54, 13);
            this.RentPriceSliderLabel2.TabIndex = 7;
            this.RentPriceSliderLabel2.Text = "15000 kr |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Square Feet Minimum";
            // 
            // EstateSqrftSlider
            // 
            this.EstateSqrftSlider.LargeChange = 200;
            this.EstateSqrftSlider.Location = new System.Drawing.Point(168, 120);
            this.EstateSqrftSlider.Maximum = 2000;
            this.EstateSqrftSlider.Minimum = 10;
            this.EstateSqrftSlider.Name = "EstateSqrftSlider";
            this.EstateSqrftSlider.Size = new System.Drawing.Size(162, 45);
            this.EstateSqrftSlider.SmallChange = 100;
            this.EstateSqrftSlider.TabIndex = 8;
            this.EstateSqrftSlider.Value = 10;
            this.EstateSqrftSlider.Scroll += new System.EventHandler(this.EstateSqrftSlider_Scroll);
            // 
            // EstateRentSlider
            // 
            this.EstateRentSlider.LargeChange = 1000;
            this.EstateRentSlider.Location = new System.Drawing.Point(1, 120);
            this.EstateRentSlider.Maximum = 15000;
            this.EstateRentSlider.Minimum = 1000;
            this.EstateRentSlider.Name = "EstateRentSlider";
            this.EstateRentSlider.Size = new System.Drawing.Size(162, 45);
            this.EstateRentSlider.SmallChange = 100;
            this.EstateRentSlider.TabIndex = 4;
            this.EstateRentSlider.Value = 15000;
            this.EstateRentSlider.Scroll += new System.EventHandler(this.EstateRentSlider_Scroll);
            // 
            // NewResidenceButton
            // 
            this.NewResidenceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewResidenceButton.Location = new System.Drawing.Point(6, 494);
            this.NewResidenceButton.Name = "NewResidenceButton";
            this.NewResidenceButton.Size = new System.Drawing.Size(143, 23);
            this.NewResidenceButton.TabIndex = 25;
            this.NewResidenceButton.Text = "Create New Estate";
            this.NewResidenceButton.UseVisualStyleBackColor = true;
            this.NewResidenceButton.Click += new System.EventHandler(this.NewResidenceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.ImageUpload);
            this.groupBox1.Controls.Add(this.EstateLegalMenu);
            this.groupBox1.Controls.Add(this.EstateTypeMenu);
            this.groupBox1.Controls.Add(this.EstateCountryMenu);
            this.groupBox1.Controls.Add(this.EditInfo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EstateUpdateButton);
            this.groupBox1.Controls.Add(this.SqrftLabel);
            this.groupBox1.Controls.Add(this.RentLabel);
            this.groupBox1.Controls.Add(this.EstateRent);
            this.groupBox1.Controls.Add(this.EstateSqrft);
            this.groupBox1.Controls.Add(this.EstateCity);
            this.groupBox1.Controls.Add(this.EstateZip);
            this.groupBox1.Controls.Add(this.EstateStreet);
            this.groupBox1.Controls.Add(this.EstateId);
            this.groupBox1.Controls.Add(this.DisplayImage);
            this.groupBox1.Location = new System.Drawing.Point(354, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BuildingDisplay";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Red;
            this.DeleteButton.Location = new System.Drawing.Point(153, 457);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 23);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Delete Estate";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ImageUpload
            // 
            this.ImageUpload.Location = new System.Drawing.Point(291, 187);
            this.ImageUpload.Name = "ImageUpload";
            this.ImageUpload.Size = new System.Drawing.Size(98, 23);
            this.ImageUpload.TabIndex = 25;
            this.ImageUpload.Text = "Image Upload";
            this.ImageUpload.UseVisualStyleBackColor = true;
            this.ImageUpload.Click += new System.EventHandler(this.ImageUpload_Click);
            // 
            // EstateLegalMenu
            // 
            this.EstateLegalMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstateLegalMenu.FormattingEnabled = true;
            this.EstateLegalMenu.Items.AddRange(new object[] {
            "Ownership",
            "Rental",
            "Tenement"});
            this.EstateLegalMenu.Location = new System.Drawing.Point(36, 275);
            this.EstateLegalMenu.Name = "EstateLegalMenu";
            this.EstateLegalMenu.Size = new System.Drawing.Size(159, 21);
            this.EstateLegalMenu.TabIndex = 24;
            // 
            // EstateTypeMenu
            // 
            this.EstateTypeMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstateTypeMenu.FormattingEnabled = true;
            this.EstateTypeMenu.Items.AddRange(new object[] {
            "House",
            "Villa",
            "Apartment",
            "Rowhouse",
            "Shop",
            "Warehouse"});
            this.EstateTypeMenu.Location = new System.Drawing.Point(36, 236);
            this.EstateTypeMenu.Name = "EstateTypeMenu";
            this.EstateTypeMenu.Size = new System.Drawing.Size(159, 21);
            this.EstateTypeMenu.TabIndex = 23;
            // 
            // EstateCountryMenu
            // 
            this.EstateCountryMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstateCountryMenu.FormattingEnabled = true;
            this.EstateCountryMenu.Items.AddRange(new object[] {
            "Afghanistan",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua_and_Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia_and_Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina_Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape_Verde",
            "Central_African_Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Democratic_Republic_of_the_Congo",
            "Costa_Rica",
            "Côte_d_Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech_Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican_Republic",
            "East_Timor_or_Timur",
            "Ecuador",
            "Egypt",
            "El_Salvador",
            "Equatorial_Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea_Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea_North",
            "Korea_South",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall_Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia_Federated_States_of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New_Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua_New_Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint_Kitts_and_Nevis",
            "Saint_Lucia",
            "Saint_Vincent_and_The_Grenadines",
            "Samoa",
            "San_Marino",
            "Sao_Tome_and_Principe",
            "Saudi_Arabia",
            "Senegal",
            "Serbia_and_Montenegro",
            "Seychelles",
            "Sierra_Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon_Islands",
            "Somalia",
            "South_Africa",
            "Spain",
            "Sri_Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sverige",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad_and_Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United_Arab_Emirates",
            "United_Kingdom",
            "United_States_of_America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican_City",
            "Venezuela",
            "Vietnam",
            "Western_Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.EstateCountryMenu.Location = new System.Drawing.Point(36, 198);
            this.EstateCountryMenu.Name = "EstateCountryMenu";
            this.EstateCountryMenu.Size = new System.Drawing.Size(159, 21);
            this.EstateCountryMenu.TabIndex = 12;
            // 
            // EditInfo
            // 
            this.EditInfo.BackColor = System.Drawing.Color.Moccasin;
            this.EditInfo.Location = new System.Drawing.Point(217, 276);
            this.EditInfo.Multiline = true;
            this.EditInfo.Name = "EditInfo";
            this.EditInfo.ReadOnly = true;
            this.EditInfo.Size = new System.Drawing.Size(143, 59);
            this.EditInfo.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Estate ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Street";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Zip Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estate Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Legal Type";
            // 
            // EstateUpdateButton
            // 
            this.EstateUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EstateUpdateButton.Enabled = false;
            this.EstateUpdateButton.Location = new System.Drawing.Point(217, 347);
            this.EstateUpdateButton.Name = "EstateUpdateButton";
            this.EstateUpdateButton.Size = new System.Drawing.Size(143, 23);
            this.EstateUpdateButton.TabIndex = 13;
            this.EstateUpdateButton.Text = "Update info";
            this.EstateUpdateButton.UseVisualStyleBackColor = true;
            this.EstateUpdateButton.Click += new System.EventHandler(this.EstateUpdateButtonClick);
            // 
            // SqrftLabel
            // 
            this.SqrftLabel.AutoSize = true;
            this.SqrftLabel.Location = new System.Drawing.Point(20, 299);
            this.SqrftLabel.Name = "SqrftLabel";
            this.SqrftLabel.Size = new System.Drawing.Size(65, 13);
            this.SqrftLabel.TabIndex = 12;
            this.SqrftLabel.Text = "Square Feet";
            // 
            // RentLabel
            // 
            this.RentLabel.AutoSize = true;
            this.RentLabel.Location = new System.Drawing.Point(19, 335);
            this.RentLabel.Name = "RentLabel";
            this.RentLabel.Size = new System.Drawing.Size(30, 13);
            this.RentLabel.TabIndex = 11;
            this.RentLabel.Text = "Rent";
            // 
            // EstateRent
            // 
            this.EstateRent.Location = new System.Drawing.Point(36, 351);
            this.EstateRent.Name = "EstateRent";
            this.EstateRent.ReadOnly = true;
            this.EstateRent.Size = new System.Drawing.Size(159, 20);
            this.EstateRent.TabIndex = 10;
            this.EstateRent.Tag = "EstateDisplayValues";
            // 
            // EstateSqrft
            // 
            this.EstateSqrft.Location = new System.Drawing.Point(36, 315);
            this.EstateSqrft.Name = "EstateSqrft";
            this.EstateSqrft.ReadOnly = true;
            this.EstateSqrft.Size = new System.Drawing.Size(159, 20);
            this.EstateSqrft.TabIndex = 9;
            this.EstateSqrft.Tag = "EstateDisplayValues";
            // 
            // EstateCity
            // 
            this.EstateCity.Location = new System.Drawing.Point(36, 159);
            this.EstateCity.Name = "EstateCity";
            this.EstateCity.ReadOnly = true;
            this.EstateCity.Size = new System.Drawing.Size(159, 20);
            this.EstateCity.TabIndex = 4;
            this.EstateCity.Tag = "EstateDisplayValues";
            // 
            // EstateZip
            // 
            this.EstateZip.Location = new System.Drawing.Point(36, 120);
            this.EstateZip.Name = "EstateZip";
            this.EstateZip.ReadOnly = true;
            this.EstateZip.Size = new System.Drawing.Size(159, 20);
            this.EstateZip.TabIndex = 3;
            this.EstateZip.Tag = "EstateDisplayValues";
            // 
            // EstateStreet
            // 
            this.EstateStreet.Location = new System.Drawing.Point(36, 84);
            this.EstateStreet.Name = "EstateStreet";
            this.EstateStreet.ReadOnly = true;
            this.EstateStreet.Size = new System.Drawing.Size(159, 20);
            this.EstateStreet.TabIndex = 2;
            this.EstateStreet.Tag = "EstateDisplayValues";
            // 
            // EstateId
            // 
            this.EstateId.Location = new System.Drawing.Point(36, 45);
            this.EstateId.Name = "EstateId";
            this.EstateId.ReadOnly = true;
            this.EstateId.Size = new System.Drawing.Size(159, 20);
            this.EstateId.TabIndex = 1;
            this.EstateId.Tag = "EstateDisplayValues";
            // 
            // DisplayImage
            // 
            this.DisplayImage.BackColor = System.Drawing.Color.Maroon;
            this.DisplayImage.Location = new System.Drawing.Point(203, 36);
            this.DisplayImage.Name = "DisplayImage";
            this.DisplayImage.Size = new System.Drawing.Size(205, 144);
            this.DisplayImage.TabIndex = 0;
            this.DisplayImage.TabStop = false;
            // 
            // EstateList
            // 
            this.EstateList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EstateList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EstateList.FormattingEnabled = true;
            this.EstateList.Location = new System.Drawing.Point(3, 227);
            this.EstateList.Name = "EstateList";
            this.EstateList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EstateList.ScrollAlwaysVisible = true;
            this.EstateList.Size = new System.Drawing.Size(348, 262);
            this.EstateList.TabIndex = 0;
            this.EstateList.SelectedValueChanged += new System.EventHandler(this.EstateList_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator1,
            this.mnuXML,
            this.toolStripSeparator2,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(180, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open ...";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAs.Text = "Save as ...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuXML
            // 
            this.mnuXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXMLImport,
            this.mnuXMLExport});
            this.mnuXML.Name = "mnuXML";
            this.mnuXML.Size = new System.Drawing.Size(180, 22);
            this.mnuXML.Text = "XML";
            // 
            // mnuXMLImport
            // 
            this.mnuXMLImport.Name = "mnuXMLImport";
            this.mnuXMLImport.Size = new System.Drawing.Size(187, 22);
            this.mnuXMLImport.Text = "Import from XML File";
            // 
            // mnuXMLExport
            // 
            this.mnuXMLExport.Name = "mnuXMLExport";
            this.mnuXMLExport.Size = new System.Drawing.Size(187, 22);
            this.mnuXMLExport.Text = "Export to XML File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Homes for Sale";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstateSqrftSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstateRentSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }







        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox SearchBoxLegal;
        private System.Windows.Forms.ComboBox SearchBoxType;
        private System.Windows.Forms.ComboBox SearchBoxCountry;
        private System.Windows.Forms.TextBox SearchBarCity;
        private System.Windows.Forms.TextBox SearchBarZip;
        private System.Windows.Forms.TextBox SearchBarStreet;
        private System.Windows.Forms.Label RentPriceSliderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Thousand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RentPriceSliderLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar EstateSqrftSlider;
        private System.Windows.Forms.TrackBar EstateRentSlider;
        private System.Windows.Forms.Button NewResidenceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ImageUpload;
        private System.Windows.Forms.ComboBox EstateLegalMenu;
        private System.Windows.Forms.ComboBox EstateTypeMenu;
        private System.Windows.Forms.ComboBox EstateCountryMenu;
        private System.Windows.Forms.TextBox EditInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EstateUpdateButton;
        private System.Windows.Forms.Label SqrftLabel;
        private System.Windows.Forms.Label RentLabel;
        private System.Windows.Forms.TextBox EstateRent;
        private System.Windows.Forms.TextBox EstateSqrft;
        private System.Windows.Forms.TextBox EstateCity;
        private System.Windows.Forms.TextBox EstateZip;
        private System.Windows.Forms.TextBox EstateStreet;
        private System.Windows.Forms.TextBox EstateId;
        private System.Windows.Forms.PictureBox DisplayImage;
        private System.Windows.Forms.ListBox EstateList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox SearchRentDisplay;
        private System.Windows.Forms.TextBox SearchSqrftDisplay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label NumberOfHiddenItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuXML;
        private System.Windows.Forms.ToolStripMenuItem mnuXMLImport;
        private System.Windows.Forms.ToolStripMenuItem mnuXMLExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}

