namespace Final_Project___Marven_Younes_and_Andrew_Fakhry
{
    partial class GMS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GMS));
            StudentName = new TextBox();
            StudentGrade = new NumericUpDown();
            EnrollmentYear = new ComboBox();
            SaveData = new Button();
            ApplyData = new Button();
            LoadData = new Button();
            CountPassFail = new Button();
            label1 = new Label();
            Student = new Label();
            Enrollementyear = new Label();
            Grade = new Label();
            CalculateStats = new Button();
            menuStrip1 = new MenuStrip();
            MenuTab = new ToolStripMenuItem();
            OpenFile = new ToolStripMenuItem();
            NewFile = new ToolStripMenuItem();
            SaveFile = new ToolStripMenuItem();
            dataGrid = new DataGridView();
            ApplyRaise = new Button();
            RaiseValue = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)StudentGrade).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RaiseValue).BeginInit();
            SuspendLayout();
            // 
            // StudentName
            // 
            StudentName.Location = new Point(52, 74);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(225, 23);
            StudentName.TabIndex = 0;
            StudentName.TextChanged += StudentName_TextChanged;
            // 
            // StudentGrade
            // 
            StudentGrade.Location = new Point(219, 162);
            StudentGrade.Name = "StudentGrade";
            StudentGrade.Size = new Size(58, 23);
            StudentGrade.TabIndex = 1;
            StudentGrade.ValueChanged += StudentGrade_ValueChanged;
            // 
            // EnrollmentYear
            // 
            EnrollmentYear.FormattingEnabled = true;
            EnrollmentYear.Items.AddRange(new object[] { "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100" });
            EnrollmentYear.Location = new Point(219, 123);
            EnrollmentYear.MaxLength = 150;
            EnrollmentYear.Name = "EnrollmentYear";
            EnrollmentYear.Size = new Size(58, 23);
            EnrollmentYear.Sorted = true;
            EnrollmentYear.TabIndex = 2;
            EnrollmentYear.SelectedIndexChanged += EnrollmentYear_SelectedIndexChanged;
            // 
            // SaveData
            // 
            SaveData.Location = new Point(786, 492);
            SaveData.Name = "SaveData";
            SaveData.Size = new Size(75, 23);
            SaveData.TabIndex = 3;
            SaveData.Text = "Save";
            SaveData.UseVisualStyleBackColor = true;
            SaveData.Click += SaveData_Click;
            // 
            // ApplyData
            // 
            ApplyData.Location = new Point(53, 188);
            ApplyData.Name = "ApplyData";
            ApplyData.Size = new Size(75, 23);
            ApplyData.TabIndex = 4;
            ApplyData.Text = "Add";
            ApplyData.UseVisualStyleBackColor = true;
            ApplyData.Click += ApplyData_Click;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(867, 492);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(75, 23);
            LoadData.TabIndex = 5;
            LoadData.Text = "Load";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // CountPassFail
            // 
            CountPassFail.Location = new Point(510, 492);
            CountPassFail.Name = "CountPassFail";
            CountPassFail.Size = new Size(75, 23);
            CountPassFail.TabIndex = 6;
            CountPassFail.Text = "Count";
            CountPassFail.UseVisualStyleBackColor = true;
            CountPassFail.Click += CountPassFail_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.Location = new Point(53, 56);
            Student.Name = "Student";
            Student.Size = new Size(83, 15);
            Student.TabIndex = 7;
            Student.Text = "Student Name";
            // 
            // Enrollementyear
            // 
            Enrollementyear.AutoSize = true;
            Enrollementyear.Location = new Point(52, 123);
            Enrollementyear.Name = "Enrollementyear";
            Enrollementyear.Size = new Size(96, 15);
            Enrollementyear.TabIndex = 8;
            Enrollementyear.Text = "Enrollement Year";
            // 
            // Grade
            // 
            Grade.AutoSize = true;
            Grade.Location = new Point(53, 162);
            Grade.Name = "Grade";
            Grade.Size = new Size(82, 15);
            Grade.TabIndex = 9;
            Grade.Text = "Student Grade";
            // 
            // CalculateStats
            // 
            CalculateStats.Location = new Point(591, 492);
            CalculateStats.Name = "CalculateStats";
            CalculateStats.Size = new Size(75, 23);
            CalculateStats.TabIndex = 10;
            CalculateStats.Text = "Calculate";
            CalculateStats.UseVisualStyleBackColor = true;
            CalculateStats.Click += CalculateStats_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuTab });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuTab
            // 
            MenuTab.BackColor = SystemColors.ButtonFace;
            MenuTab.DropDownItems.AddRange(new ToolStripItem[] { OpenFile, NewFile, SaveFile });
            MenuTab.Name = "MenuTab";
            MenuTab.Size = new Size(50, 20);
            MenuTab.Text = "Menu";
            // 
            // OpenFile
            // 
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(103, 22);
            OpenFile.Text = "Open";
            OpenFile.Click += OpenFile_Click;
            // 
            // NewFile
            // 
            NewFile.Name = "NewFile";
            NewFile.Size = new Size(103, 22);
            NewFile.Text = "New";
            NewFile.Click += NewFile_Click;
            // 
            // SaveFile
            // 
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(103, 22);
            SaveFile.Text = "Save";
            SaveFile.Click += SaveFile_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Location = new Point(362, 56);
            dataGrid.Margin = new Padding(1, 4, 4, 3);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 185;
            dataGrid.Size = new Size(580, 430);
            dataGrid.TabIndex = 12;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // ApplyRaise
            // 
            ApplyRaise.Location = new Point(426, 492);
            ApplyRaise.Name = "ApplyRaise";
            ApplyRaise.Size = new Size(78, 23);
            ApplyRaise.TabIndex = 13;
            ApplyRaise.Text = "Apply Raise";
            ApplyRaise.UseVisualStyleBackColor = true;
            ApplyRaise.Click += ApplyRaise_Click;
            // 
            // RaiseValue
            // 
            RaiseValue.Location = new Point(362, 492);
            RaiseValue.Name = "RaiseValue";
            RaiseValue.Size = new Size(58, 23);
            RaiseValue.TabIndex = 14;
            RaiseValue.ValueChanged += RaiseValue_ValueChanged;
            // 
            // GMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(978, 551);
            Controls.Add(RaiseValue);
            Controls.Add(ApplyRaise);
            Controls.Add(dataGrid);
            Controls.Add(CalculateStats);
            Controls.Add(Grade);
            Controls.Add(Enrollementyear);
            Controls.Add(Student);
            Controls.Add(CountPassFail);
            Controls.Add(LoadData);
            Controls.Add(ApplyData);
            Controls.Add(SaveData);
            Controls.Add(EnrollmentYear);
            Controls.Add(StudentGrade);
            Controls.Add(StudentName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GMS";
            Text = "Grade Management System";
            Load += GMS_Load;
            ((System.ComponentModel.ISupportInitialize)StudentGrade).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RaiseValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StudentName;
        private NumericUpDown StudentGrade;
        private ComboBox EnrollmentYear;
        private Button SaveData;
        private Button ApplyData;
        private Button LoadData;
        private Button CountPassFail;
        private Label label1;
        private Label Student;
        private Label Enrollementyear;
        private Label Grade;
        private Button CalculateStats;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuTab;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem NewFile;
        private ToolStripMenuItem SaveFile;
        private DataGridView dataGrid;
        private Button ApplyRaise;
        private NumericUpDown RaiseValue;
    }
}
