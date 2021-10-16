namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    partial class FormFacebookPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label hometownLabel;
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxPosts = new ActionListBoxProxy();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new ActionListBoxProxy();
            this.labelEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new ActionListBoxProxy();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.listBoxAlbums = new ActionListBoxProxy();
            this.listBoxFavoriteTeams = new ActionListBoxProxy();
            this.labelFavoriteTeams = new System.Windows.Forms.Label();
            this.labelFriendsBirthday = new System.Windows.Forms.Label();
            this.listBoxFriendsBirthday = new ActionListBoxProxy();
            this.labelTagged = new System.Windows.Forms.Label();
            this.listBoxTaggedPlaces = new ActionListBoxProxy();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTipEvents = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxLikes = new ActionListBoxProxy();
            this.labelLikes = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelCountToBirhday = new System.Windows.Forms.Label();
            this.birthdayLabelDetails = new System.Windows.Forms.Label();
            this.logicFacebookPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailLabelDetails = new System.Windows.Forms.Label();
            this.genderLabelDetails = new System.Windows.Forms.Label();
            this.hometownLabelDetails = new System.Windows.Forms.Label();
            this.nameLabelDetails = new System.Windows.Forms.Label();
            this.coverPictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureURLPictureBox = new System.Windows.Forms.PictureBox();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            hometownLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logicFacebookPageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureURLPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(31, 367);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(60, 16);
            birthdayLabel.TabIndex = 31;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(31, 303);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 16);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(31, 271);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(56, 16);
            genderLabel.TabIndex = 35;
            genderLabel.Text = "Gender:";
            // 
            // hometownLabel
            // 
            hometownLabel.AutoSize = true;
            hometownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hometownLabel.Location = new System.Drawing.Point(31, 335);
            hometownLabel.Name = "hometownLabel";
            hometownLabel.Size = new System.Drawing.Size(75, 16);
            hometownLabel.TabIndex = 37;
            hometownLabel.Text = "Hometown:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttomLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(378, 319);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(702, 95);
            this.listBoxPosts.TabIndex = 10;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.Location = new System.Drawing.Point(375, 296);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(48, 16);
            this.labelPosts.TabIndex = 11;
            this.labelPosts.Text = "Posts: ";
            // 
            // labelFriends
            // 
            this.labelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(55, 450);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(56, 16);
            this.labelFriends.TabIndex = 12;
            this.labelFriends.Text = "Friends:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriends.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(34, 474);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(175, 134);
            this.listBoxFriends.TabIndex = 13;
            // 
            // labelEvents
            // 
            this.labelEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.Location = new System.Drawing.Point(1164, 450);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(52, 16);
            this.labelEvents.TabIndex = 14;
            this.labelEvents.Text = "Events:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(1120, 474);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(175, 134);
            this.listBoxEvents.TabIndex = 15;
            this.listBoxEvents.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxEvents_MouseMove);
            // 
            // labelAlbums
            // 
            this.labelAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.Location = new System.Drawing.Point(440, 450);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(56, 16);
            this.labelAlbums.TabIndex = 16;
            this.labelAlbums.Text = "Albums:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(396, 474);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(175, 134);
            this.listBoxAlbums.TabIndex = 17;
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(577, 474);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(175, 134);
            this.listBoxFavoriteTeams.TabIndex = 18;
            // 
            // labelFavoriteTeams
            // 
            this.labelFavoriteTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFavoriteTeams.AutoSize = true;
            this.labelFavoriteTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFavoriteTeams.Location = new System.Drawing.Point(593, 450);
            this.labelFavoriteTeams.Name = "labelFavoriteTeams";
            this.labelFavoriteTeams.Size = new System.Drawing.Size(106, 16);
            this.labelFavoriteTeams.TabIndex = 19;
            this.labelFavoriteTeams.Text = "Favorite Teams:";
            // 
            // labelFriendsBirthday
            // 
            this.labelFriendsBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFriendsBirthday.AutoSize = true;
            this.labelFriendsBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsBirthday.Location = new System.Drawing.Point(787, 450);
            this.labelFriendsBirthday.Name = "labelFriendsBirthday";
            this.labelFriendsBirthday.Size = new System.Drawing.Size(108, 16);
            this.labelFriendsBirthday.TabIndex = 20;
            this.labelFriendsBirthday.Text = "Friends Birthday:";
            // 
            // listBoxFriendsBirthday
            // 
            this.listBoxFriendsBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriendsBirthday.FormattingEnabled = true;
            this.listBoxFriendsBirthday.Location = new System.Drawing.Point(758, 474);
            this.listBoxFriendsBirthday.Name = "listBoxFriendsBirthday";
            this.listBoxFriendsBirthday.Size = new System.Drawing.Size(175, 134);
            this.listBoxFriendsBirthday.TabIndex = 21;
            // 
            // labelTagged
            // 
            this.labelTagged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTagged.AutoSize = true;
            this.labelTagged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagged.Location = new System.Drawing.Point(975, 450);
            this.labelTagged.Name = "labelTagged";
            this.labelTagged.Size = new System.Drawing.Size(105, 16);
            this.labelTagged.TabIndex = 22;
            this.labelTagged.Text = "Tagged Places:";
            // 
            // listBoxTaggedPlaces
            // 
            this.listBoxTaggedPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTaggedPlaces.FormattingEnabled = true;
            this.listBoxTaggedPlaces.Location = new System.Drawing.Point(939, 474);
            this.listBoxTaggedPlaces.Name = "listBoxTaggedPlaces";
            this.listBoxTaggedPlaces.Size = new System.Drawing.Size(175, 134);
            this.listBoxTaggedPlaces.TabIndex = 23;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(13, 42);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 24;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // listBoxLikes
            // 
            this.listBoxLikes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLikes.FormattingEnabled = true;
            this.listBoxLikes.Location = new System.Drawing.Point(215, 474);
            this.listBoxLikes.Name = "listBoxLikes";
            this.listBoxLikes.Size = new System.Drawing.Size(175, 134);
            this.listBoxLikes.TabIndex = 27;
            // 
            // labelLikes
            // 
            this.labelLikes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikes.Location = new System.Drawing.Point(255, 450);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(43, 16);
            this.labelLikes.TabIndex = 26;
            this.labelLikes.Text = "Likes:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(378, 264);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(702, 20);
            this.textBoxPost.TabIndex = 28;
            this.textBoxPost.Enter += new System.EventHandler(this.textBoxPost_Enter);
            this.textBoxPost.Leave += new System.EventHandler(this.textBoxPost_Leave);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1086, 259);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(78, 28);
            this.buttonPost.TabIndex = 29;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(93, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 30;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Visible = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelCountToBirhday
            // 
            this.labelCountToBirhday.AutoSize = true;
            this.labelCountToBirhday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountToBirhday.ForeColor = System.Drawing.Color.Navy;
            this.labelCountToBirhday.Location = new System.Drawing.Point(31, 420);
            this.labelCountToBirhday.Name = "labelCountToBirhday";
            this.labelCountToBirhday.Size = new System.Drawing.Size(0, 16);
            this.labelCountToBirhday.TabIndex = 25;
            // 
            // birthdayLabelDetails
            // 
            this.birthdayLabelDetails.AutoSize = true;
            this.birthdayLabelDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logicFacebookPageBindingSource, "Birthday", true));
            this.birthdayLabelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabelDetails.Location = new System.Drawing.Point(106, 367);
            this.birthdayLabelDetails.Name = "birthdayLabelDetails";
            this.birthdayLabelDetails.Size = new System.Drawing.Size(0, 16);
            this.birthdayLabelDetails.TabIndex = 32;
            // 
            // logicFacebookPageBindingSource
            // 
            this.logicFacebookPageBindingSource.DataSource = typeof(A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473.MainFacebookPageFacade);
            // 
            // emailLabelDetails
            // 
            this.emailLabelDetails.AutoSize = true;
            this.emailLabelDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logicFacebookPageBindingSource, "Email", true));
            this.emailLabelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabelDetails.Location = new System.Drawing.Point(106, 303);
            this.emailLabelDetails.Name = "emailLabelDetails";
            this.emailLabelDetails.Size = new System.Drawing.Size(0, 16);
            this.emailLabelDetails.TabIndex = 34;
            // 
            // genderLabelDetails
            // 
            this.genderLabelDetails.AutoSize = true;
            this.genderLabelDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logicFacebookPageBindingSource, "Gender", true));
            this.genderLabelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabelDetails.Location = new System.Drawing.Point(106, 271);
            this.genderLabelDetails.Name = "genderLabelDetails";
            this.genderLabelDetails.Size = new System.Drawing.Size(0, 16);
            this.genderLabelDetails.TabIndex = 36;
            // 
            // hometownLabelDetails
            // 
            this.hometownLabelDetails.AutoSize = true;
            this.hometownLabelDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logicFacebookPageBindingSource, "Hometown", true));
            this.hometownLabelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometownLabelDetails.Location = new System.Drawing.Point(106, 335);
            this.hometownLabelDetails.Name = "hometownLabelDetails";
            this.hometownLabelDetails.Size = new System.Drawing.Size(0, 16);
            this.hometownLabelDetails.TabIndex = 38;
            // 
            // nameLabelDetails
            // 
            this.nameLabelDetails.AutoSize = true;
            this.nameLabelDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logicFacebookPageBindingSource, "Name", true));
            this.nameLabelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelDetails.Location = new System.Drawing.Point(31, 201);
            this.nameLabelDetails.Name = "nameLabelDetails";
            this.nameLabelDetails.Size = new System.Drawing.Size(0, 16);
            this.nameLabelDetails.TabIndex = 40;
            // 
            // coverPictureURLPictureBox
            // 
            this.coverPictureURLPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coverPictureURLPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coverPictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.logicFacebookPageBindingSource, "CoverPictureURL", true));
            this.coverPictureURLPictureBox.Location = new System.Drawing.Point(13, 12);
            this.coverPictureURLPictureBox.Name = "coverPictureURLPictureBox";
            this.coverPictureURLPictureBox.Size = new System.Drawing.Size(1281, 232);
            this.coverPictureURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureURLPictureBox.TabIndex = 41;
            this.coverPictureURLPictureBox.TabStop = false;
            // 
            // profilePictureURLPictureBox
            // 
            this.profilePictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.logicFacebookPageBindingSource, "ProfilePictureURL", true));
            this.profilePictureURLPictureBox.Location = new System.Drawing.Point(29, 95);
            this.profilePictureURLPictureBox.Name = "profilePictureURLPictureBox";
            this.profilePictureURLPictureBox.Size = new System.Drawing.Size(100, 103);
            this.profilePictureURLPictureBox.TabIndex = 42;
            this.profilePictureURLPictureBox.TabStop = false;
            // 
            // FormFacebookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 635);
            this.Controls.Add(this.profilePictureURLPictureBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayLabelDetails);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailLabelDetails);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderLabelDetails);
            this.Controls.Add(hometownLabel);
            this.Controls.Add(this.hometownLabelDetails);
            this.Controls.Add(this.nameLabelDetails);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.listBoxLikes);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.labelCountToBirhday);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.listBoxTaggedPlaces);
            this.Controls.Add(this.labelTagged);
            this.Controls.Add(this.listBoxFriendsBirthday);
            this.Controls.Add(this.labelFriendsBirthday);
            this.Controls.Add(this.labelFavoriteTeams);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.coverPictureURLPictureBox);
            this.Name = "FormFacebookPage";
            this.Text = "FacebookPageForm";
            ((System.ComponentModel.ISupportInitialize)(this.logicFacebookPageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureURLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureURLPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private ActionListBoxProxy listBoxPosts;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelFriends;
        private ActionListBoxProxy listBoxFriends;
        private System.Windows.Forms.Label labelEvents;
        private ActionListBoxProxy listBoxEvents;
        private System.Windows.Forms.Label labelAlbums;
        private ActionListBoxProxy listBoxAlbums;
        private ActionListBoxProxy listBoxFavoriteTeams;
        private System.Windows.Forms.Label labelFavoriteTeams;
        private System.Windows.Forms.Label labelFriendsBirthday;
        private ActionListBoxProxy listBoxFriendsBirthday;
        private System.Windows.Forms.Label labelTagged;
        private ActionListBoxProxy listBoxTaggedPlaces;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTipEvents;
        private ActionListBoxProxy listBoxLikes;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelCountToBirhday;
        private System.Windows.Forms.BindingSource logicFacebookPageBindingSource;
        private System.Windows.Forms.Label birthdayLabelDetails;
        private System.Windows.Forms.Label emailLabelDetails;
        private System.Windows.Forms.Label genderLabelDetails;
        private System.Windows.Forms.Label hometownLabelDetails;
        private System.Windows.Forms.Label nameLabelDetails;
        private System.Windows.Forms.PictureBox coverPictureURLPictureBox;
        private System.Windows.Forms.PictureBox profilePictureURLPictureBox;
    }
}