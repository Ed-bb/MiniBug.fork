namespace MiniBug
{
    partial class MainForm
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
            GridIssues = new System.Windows.Forms.DataGridView();
            TabControl = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            GridTasks = new System.Windows.Forms.DataGridView();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            IconNewIssue = new System.Windows.Forms.ToolStripButton();
            IconEditIssue = new System.Windows.Forms.ToolStripButton();
            IconDeleteIssue = new System.Windows.Forms.ToolStripButton();
            IconCloneIssue = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            IconNewTask = new System.Windows.Forms.ToolStripButton();
            IconEditTask = new System.Windows.Forms.ToolStripButton();
            IconDeleteTask = new System.Windows.Forms.ToolStripButton();
            IconCloneTask = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            IconConfigureColumns = new System.Windows.Forms.ToolStripButton();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            configureColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearRecentProjectsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            issuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cloneIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cloneTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutMiniBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)GridIssues).BeginInit();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridTasks).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GridIssues
            // 
            GridIssues.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            GridIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridIssues.Location = new System.Drawing.Point(6, 6);
            GridIssues.Name = "GridIssues";
            GridIssues.RowHeadersWidth = 51;
            GridIssues.Size = new System.Drawing.Size(778, 320);
            GridIssues.TabIndex = 0;
            GridIssues.CellDoubleClick += GridIssues_CellDoubleClick;
            GridIssues.CellFormatting += GridIssues_CellFormatting;
            GridIssues.CellPainting += GridIssues_CellPainting;
            GridIssues.ColumnDisplayIndexChanged += GridIssues_ColumnDisplayIndexChanged;
            GridIssues.ColumnHeaderMouseClick += GridIssues_ColumnHeaderMouseClick;
            GridIssues.SelectionChanged += GridIssues_SelectionChanged;
            GridIssues.KeyDown += GridIssues_KeyDown;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            TabControl.Location = new System.Drawing.Point(0, 86);
            TabControl.Margin = new System.Windows.Forms.Padding(0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(801, 364);
            TabControl.TabIndex = 2;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(GridIssues);
            tabPage1.Location = new System.Drawing.Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(793, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Issues";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GridTasks);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(791, 332);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tasks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridTasks
            // 
            GridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTasks.Location = new System.Drawing.Point(6, 6);
            GridTasks.Name = "GridTasks";
            GridTasks.RowHeadersWidth = 51;
            GridTasks.Size = new System.Drawing.Size(776, 343);
            GridTasks.TabIndex = 0;
            GridTasks.CellDoubleClick += GridTasks_CellDoubleClick;
            GridTasks.CellFormatting += GridTasks_CellFormatting;
            GridTasks.CellPainting += GridTasks_CellPainting;
            GridTasks.ColumnDisplayIndexChanged += GridTasks_ColumnDisplayIndexChanged;
            GridTasks.ColumnHeaderMouseClick += GridTasks_ColumnHeaderMouseClick;
            GridTasks.SelectionChanged += GridTasks_SelectionChanged;
            GridTasks.KeyDown += GridTasks_KeyDown;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { IconNewIssue, IconEditIssue, IconDeleteIssue, IconCloneIssue, toolStripSeparator2, IconNewTask, IconEditTask, IconDeleteTask, IconCloneTask, toolStripSeparator5, IconConfigureColumns });
            toolStrip1.Location = new System.Drawing.Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(801, 58);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // IconNewIssue
            // 
            IconNewIssue.Image = Properties.Resources.NewBug_32x32;
            IconNewIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            IconNewIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconNewIssue.Name = "IconNewIssue";
            IconNewIssue.Size = new System.Drawing.Size(40, 55);
            IconNewIssue.Text = "New";
            IconNewIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconNewIssue.ToolTipText = "New Issue";
            IconNewIssue.Click += IconNewIssue_Click;
            // 
            // IconEditIssue
            // 
            IconEditIssue.Image = Properties.Resources.EditBug_32x32;
            IconEditIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            IconEditIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconEditIssue.Name = "IconEditIssue";
            IconEditIssue.Size = new System.Drawing.Size(36, 55);
            IconEditIssue.Text = "Edit";
            IconEditIssue.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            IconEditIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconEditIssue.ToolTipText = "Edit Selected Issue";
            IconEditIssue.Click += IconEditIssue_Click;
            // 
            // IconDeleteIssue
            // 
            IconDeleteIssue.Image = Properties.Resources.DeleteBug_32x32;
            IconDeleteIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            IconDeleteIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconDeleteIssue.Name = "IconDeleteIssue";
            IconDeleteIssue.Size = new System.Drawing.Size(52, 55);
            IconDeleteIssue.Text = "Delete";
            IconDeleteIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconDeleteIssue.ToolTipText = "Delete Selected Issues";
            IconDeleteIssue.Click += IconDeleteIssue_Click;
            // 
            // IconCloneIssue
            // 
            IconCloneIssue.Image = Properties.Resources.CloneBug_32x32;
            IconCloneIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            IconCloneIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconCloneIssue.Name = "IconCloneIssue";
            IconCloneIssue.Size = new System.Drawing.Size(48, 55);
            IconCloneIssue.Text = "Clone";
            IconCloneIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconCloneIssue.ToolTipText = "Clone Selected Issue";
            IconCloneIssue.Click += IconCloneIssue_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // IconNewTask
            // 
            IconNewTask.Image = Properties.Resources.NewTask_32x32;
            IconNewTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            IconNewTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconNewTask.Name = "IconNewTask";
            IconNewTask.Size = new System.Drawing.Size(40, 55);
            IconNewTask.Text = "New";
            IconNewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconNewTask.ToolTipText = "New Task";
            IconNewTask.Click += IconNewTask_Click;
            // 
            // IconEditTask
            // 
            IconEditTask.Image = Properties.Resources.EditTask_32x32;
            IconEditTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            IconEditTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconEditTask.Name = "IconEditTask";
            IconEditTask.Size = new System.Drawing.Size(36, 55);
            IconEditTask.Text = "Edit";
            IconEditTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconEditTask.ToolTipText = "Edit Selected Task";
            IconEditTask.Click += IconEditTask_Click;
            // 
            // IconDeleteTask
            // 
            IconDeleteTask.Image = Properties.Resources.DeleteTask_32x32;
            IconDeleteTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            IconDeleteTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconDeleteTask.Name = "IconDeleteTask";
            IconDeleteTask.Size = new System.Drawing.Size(52, 55);
            IconDeleteTask.Text = "Delete";
            IconDeleteTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconDeleteTask.ToolTipText = "Delete Selected Tasks";
            IconDeleteTask.Click += IconDeleteTask_Click;
            // 
            // IconCloneTask
            // 
            IconCloneTask.Image = Properties.Resources.CloneTask_32x32;
            IconCloneTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconCloneTask.Name = "IconCloneTask";
            IconCloneTask.Size = new System.Drawing.Size(48, 55);
            IconCloneTask.Text = "Clone";
            IconCloneTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconCloneTask.ToolTipText = "Clone Selected Task";
            IconCloneTask.Click += IconCloneTask_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 58);
            // 
            // IconConfigureColumns
            // 
            IconConfigureColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            IconConfigureColumns.Image = Properties.Resources.ConfigureView_32x32;
            IconConfigureColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            IconConfigureColumns.Name = "IconConfigureColumns";
            IconConfigureColumns.Size = new System.Drawing.Size(36, 55);
            IconConfigureColumns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            IconConfigureColumns.ToolTipText = "Configure column settings";
            IconConfigureColumns.Click += IconConfigureColumns_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, issuesToolStripMenuItem, tasksToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(801, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newProjectToolStripMenuItem, openProjectToolStripMenuItem, editProjectToolStripMenuItem, exportToolStripMenuItem, toolStripSeparator3, configureColumnsToolStripMenuItem, settingsToolStripMenuItem, toolStripSeparator4, recentProjectsToolStripMenuItem, clearRecentProjectsListToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            toolStripMenuItem1.Text = "&File";
            // 
            // newProjectToolStripMenuItem
            // 
            newProjectToolStripMenuItem.Image = Properties.Resources.NewProject_32x32;
            newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            newProjectToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            newProjectToolStripMenuItem.Text = "&New Project...";
            newProjectToolStripMenuItem.Click += newProjectToolStripMenuItem_Click;
            // 
            // openProjectToolStripMenuItem
            // 
            openProjectToolStripMenuItem.Image = Properties.Resources.OpenProject_32x32;
            openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            openProjectToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            openProjectToolStripMenuItem.Text = "&Open Project...";
            openProjectToolStripMenuItem.Click += openProjectToolStripMenuItem_Click;
            // 
            // editProjectToolStripMenuItem
            // 
            editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            editProjectToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            editProjectToolStripMenuItem.Text = "&Project Settings...";
            editProjectToolStripMenuItem.Click += editProjectToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            exportToolStripMenuItem.Text = "&Export...";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // configureColumnsToolStripMenuItem
            // 
            configureColumnsToolStripMenuItem.Image = Properties.Resources.ConfigureView_32x32;
            configureColumnsToolStripMenuItem.Name = "configureColumnsToolStripMenuItem";
            configureColumnsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            configureColumnsToolStripMenuItem.Text = "Confi&gure Columns";
            configureColumnsToolStripMenuItem.Click += configureColumnsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Image = Properties.Resources.Settings_32x32;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            settingsToolStripMenuItem.Text = "&Settings...";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(228, 6);
            // 
            // recentProjectsToolStripMenuItem
            // 
            recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            recentProjectsToolStripMenuItem.Text = "&Recent Projects";
            // 
            // clearRecentProjectsListToolStripMenuItem
            // 
            clearRecentProjectsListToolStripMenuItem.Image = Properties.Resources.Delete_32x32;
            clearRecentProjectsListToolStripMenuItem.Name = "clearRecentProjectsListToolStripMenuItem";
            clearRecentProjectsListToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            clearRecentProjectsListToolStripMenuItem.Text = "&Clear Recent Projects";
            clearRecentProjectsListToolStripMenuItem.Click += clearRecentProjectsListToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // issuesToolStripMenuItem
            // 
            issuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newIssueToolStripMenuItem, editIssueToolStripMenuItem, deleteIssueToolStripMenuItem, cloneIssueToolStripMenuItem });
            issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            issuesToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            issuesToolStripMenuItem.Text = "&Issues";
            // 
            // newIssueToolStripMenuItem
            // 
            newIssueToolStripMenuItem.Image = Properties.Resources.NewBug_32x32;
            newIssueToolStripMenuItem.Name = "newIssueToolStripMenuItem";
            newIssueToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            newIssueToolStripMenuItem.Text = "&New Issue...";
            newIssueToolStripMenuItem.Click += newIssueToolStripMenuItem_Click;
            // 
            // editIssueToolStripMenuItem
            // 
            editIssueToolStripMenuItem.Image = Properties.Resources.EditBug_32x32;
            editIssueToolStripMenuItem.Name = "editIssueToolStripMenuItem";
            editIssueToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            editIssueToolStripMenuItem.Text = "&Edit Issue...";
            editIssueToolStripMenuItem.Click += editIssueToolStripMenuItem_Click;
            // 
            // deleteIssueToolStripMenuItem
            // 
            deleteIssueToolStripMenuItem.Image = Properties.Resources.DeleteBug_32x32;
            deleteIssueToolStripMenuItem.Name = "deleteIssueToolStripMenuItem";
            deleteIssueToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            deleteIssueToolStripMenuItem.Text = "&Delete Issue";
            deleteIssueToolStripMenuItem.Click += deleteIssueToolStripMenuItem_Click;
            // 
            // cloneIssueToolStripMenuItem
            // 
            cloneIssueToolStripMenuItem.Image = Properties.Resources.CloneBug_32x32;
            cloneIssueToolStripMenuItem.Name = "cloneIssueToolStripMenuItem";
            cloneIssueToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            cloneIssueToolStripMenuItem.Text = "&Clone Issue";
            cloneIssueToolStripMenuItem.Click += cloneIssueToolStripMenuItem_Click;
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newTaskToolStripMenuItem, editTaskToolStripMenuItem, deleteTaskToolStripMenuItem, cloneTaskToolStripMenuItem });
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            tasksToolStripMenuItem.Text = "&Tasks";
            // 
            // newTaskToolStripMenuItem
            // 
            newTaskToolStripMenuItem.Image = Properties.Resources.NewTask_32x32;
            newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            newTaskToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            newTaskToolStripMenuItem.Text = "&New Task...";
            newTaskToolStripMenuItem.Click += newTaskToolStripMenuItem_Click;
            // 
            // editTaskToolStripMenuItem
            // 
            editTaskToolStripMenuItem.Image = Properties.Resources.EditTask_32x32;
            editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            editTaskToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            editTaskToolStripMenuItem.Text = "&Edit Task...";
            editTaskToolStripMenuItem.Click += editTaskToolStripMenuItem_Click;
            // 
            // deleteTaskToolStripMenuItem
            // 
            deleteTaskToolStripMenuItem.Image = Properties.Resources.DeleteTask_32x32;
            deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            deleteTaskToolStripMenuItem.Text = "&Delete Task";
            deleteTaskToolStripMenuItem.Click += deleteTaskToolStripMenuItem_Click;
            // 
            // cloneTaskToolStripMenuItem
            // 
            cloneTaskToolStripMenuItem.Image = Properties.Resources.CloneTask_32x32;
            cloneTaskToolStripMenuItem.Name = "cloneTaskToolStripMenuItem";
            cloneTaskToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            cloneTaskToolStripMenuItem.Text = "&Clone Task";
            cloneTaskToolStripMenuItem.Click += cloneTaskToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutMiniBugToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMiniBugToolStripMenuItem
            // 
            aboutMiniBugToolStripMenuItem.Image = Properties.Resources.About_32x32;
            aboutMiniBugToolStripMenuItem.Name = "aboutMiniBugToolStripMenuItem";
            aboutMiniBugToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            aboutMiniBugToolStripMenuItem.Text = "&About MiniBug";
            aboutMiniBugToolStripMenuItem.Click += aboutMiniBugToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(801, 450);
            Controls.Add(TabControl);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)GridIssues).EndInit();
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridTasks).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridIssues;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton IconNewIssue;
        private System.Windows.Forms.ToolStripButton IconEditIssue;
        private System.Windows.Forms.ToolStripButton IconDeleteIssue;
        private System.Windows.Forms.ToolStripButton IconCloneIssue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton IconNewTask;
        private System.Windows.Forms.ToolStripButton IconEditTask;
        private System.Windows.Forms.ToolStripButton IconDeleteTask;
        private System.Windows.Forms.DataGridView GridTasks;
        private System.Windows.Forms.ToolStripButton IconCloneTask;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMiniBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton IconConfigureColumns;
        private System.Windows.Forms.ToolStripMenuItem clearRecentProjectsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureColumnsToolStripMenuItem;
    }
}

