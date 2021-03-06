using System.ComponentModel;
using System.Windows.Forms;
using OpenCBS.GUI.UserControl;

namespace OpenCBS.GUI.Configuration
{
    public partial class UserForm
    {
        private Label lblRole;
        private TextBox txbPassword;
        private TextBox txbFirstname;
        private TextBox txbLastname;
        private TextBox txbUsername;
        private Label lblPassword;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private ComboBox cmbRoles;
        private Container components = null;
        private GroupBox gbAddUser;
        private ListView lvUsers;
        private ColumnHeader colUsername;
        private ColumnHeader colRole;
        private ColumnHeader colFirstname;
        private TextBox txbMail;
        private Label lblMail;
        private ColumnHeader cHMail;
        private TextBox txbConfirmPassword;
        private Label lbComfirmPassword;
        private ColumnHeader colLastname;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.lvUsers = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubordinates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabButtons = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubordinates = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblSecretQuestionAnswer = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lblSecretQuestion = new System.Windows.Forms.Label();
            this.txbSecretQuestion = new System.Windows.Forms.TextBox();
            this.txbSecretQuestionAnswer = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.txbLastname = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lbComfirmPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbAddUser.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colRole,
            this.colFirstname,
            this.colLastname,
            this.cHMail,
            this.colSex,
            this.colSubordinates,
            this.colPhone});
            resources.ApplyResources(this.lvUsers, "lvUsers");
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.OnSelectedUserChanged);
            this.lvUsers.Click += new System.EventHandler(this.listViewUsers_Click);
            this.lvUsers.DoubleClick += new System.EventHandler(this.OnSubordinatesClicked);
            // 
            // colUsername
            // 
            resources.ApplyResources(this.colUsername, "colUsername");
            // 
            // colRole
            // 
            resources.ApplyResources(this.colRole, "colRole");
            // 
            // colFirstname
            // 
            resources.ApplyResources(this.colFirstname, "colFirstname");
            // 
            // colLastname
            // 
            resources.ApplyResources(this.colLastname, "colLastname");
            // 
            // cHMail
            // 
            resources.ApplyResources(this.cHMail, "cHMail");
            // 
            // colSex
            // 
            resources.ApplyResources(this.colSex, "colSex");
            // 
            // colSubordinates
            // 
            resources.ApplyResources(this.colSubordinates, "colSubordinates");
            // 
            // colPhone
            // 
            resources.ApplyResources(this.colPhone, "colPhone");
            // 
            // tabButtons
            // 
            resources.ApplyResources(this.tabButtons, "tabButtons");
            this.tabButtons.Name = "tabButtons";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Controls.Add(this.btnSubordinates);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubordinates
            // 
            resources.ApplyResources(this.btnSubordinates, "btnSubordinates");
            this.btnSubordinates.Name = "btnSubordinates";
            this.btnSubordinates.Click += new System.EventHandler(this.OnSubordinatesClicked);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // gbAddUser
            // 
            this.gbAddUser.Controls.Add(this.tableLayoutPanel);
            resources.ApplyResources(this.gbAddUser, "gbAddUser");
            this.gbAddUser.Name = "gbAddUser";
            this.gbAddUser.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.lblSecretQuestionAnswer, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.cmbRoles, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.lblRole, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.txbUsername, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblSex, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.cmbSex, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.lblPhone, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txbPhone, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.lblSecretQuestion, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.txbSecretQuestion, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.txbSecretQuestionAnswer, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.txbPassword, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.txbFirstname, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.txbLastname, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txbMail, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txbConfirmPassword, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblPassword, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblFirstName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblLastName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lbComfirmPassword, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.lblMail, 0, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // lblSecretQuestionAnswer
            // 
            resources.ApplyResources(this.lblSecretQuestionAnswer, "lblSecretQuestionAnswer");
            this.lblSecretQuestionAnswer.Name = "lblSecretQuestionAnswer";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DisplayMember = "Role.RoleName";
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(56)))));
            resources.ApplyResources(this.cmbRoles, "cmbRoles");
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.SelectionChangeCommitted += new System.EventHandler(this.comboBoxRoles_SelectionChangeCommitted);
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.Name = "lblRole";
            // 
            // txbUsername
            // 
            resources.ApplyResources(this.txbUsername, "txbUsername");
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblSex, "lblSex");
            this.lblSex.Name = "lblSex";
            // 
            // cmbSex
            // 
            this.cmbSex.DisplayMember = "Value";
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSex, "cmbSex");
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.ValueMember = "Key";
            this.cmbSex.SelectionChangeCommitted += new System.EventHandler(this.cmbSex_SelectionChangeCommitted);
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // txbPhone
            // 
            resources.ApplyResources(this.txbPhone, "txbPhone");
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.TextChanged += new System.EventHandler(this.txbPhone_TextChanged);
            // 
            // lblSecretQuestion
            // 
            resources.ApplyResources(this.lblSecretQuestion, "lblSecretQuestion");
            this.lblSecretQuestion.Name = "lblSecretQuestion";
            // 
            // txbSecretQuestion
            // 
            resources.ApplyResources(this.txbSecretQuestion, "txbSecretQuestion");
            this.txbSecretQuestion.Name = "txbSecretQuestion";
            this.txbSecretQuestion.TextChanged += new System.EventHandler(this.textBoxSecretQuestion_TextChanged);
            // 
            // txbSecretQuestionAnswer
            // 
            resources.ApplyResources(this.txbSecretQuestionAnswer, "txbSecretQuestionAnswer");
            this.txbSecretQuestionAnswer.Name = "txbSecretQuestionAnswer";
            this.txbSecretQuestionAnswer.TextChanged += new System.EventHandler(this.textBoxSecretQuestionAnswer_TextChanged);
            this.txbSecretQuestionAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSecretQuestionAnswer_KeyDown);
            // 
            // txbPassword
            // 
            resources.ApplyResources(this.txbPassword, "txbPassword");
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // txbFirstname
            // 
            resources.ApplyResources(this.txbFirstname, "txbFirstname");
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.TextChanged += new System.EventHandler(this.textBoxFirstname_TextChanged);
            // 
            // txbLastname
            // 
            resources.ApplyResources(this.txbLastname, "txbLastname");
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.TextChanged += new System.EventHandler(this.textBoxLastname_TextChanged);
            // 
            // txbMail
            // 
            resources.ApplyResources(this.txbMail, "txbMail");
            this.txbMail.Name = "txbMail";
            this.txbMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // txbConfirmPassword
            // 
            resources.ApplyResources(this.txbConfirmPassword, "txbConfirmPassword");
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // lbComfirmPassword
            // 
            resources.ApplyResources(this.lbComfirmPassword, "lbComfirmPassword");
            this.lbComfirmPassword.Name = "lbComfirmPassword";
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.Name = "lblMail";
            // 
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabButtons);
            this.Controls.Add(this.gbAddUser);
            this.Name = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.Controls.SetChildIndex(this.gbAddUser, 0);
            this.Controls.SetChildIndex(this.tabButtons, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.lvUsers, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gbAddUser.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnHeader colSubordinates;
        private TableLayoutPanel tabButtons;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSubordinates;
        private System.Windows.Forms.Button btnDelete;
        private TableLayoutPanel tableLayoutPanel;
        private Label lblSex;
        private ComboBox cmbSex;
        private ColumnHeader colSex;
        private ColumnHeader colPhone;
        private Label lblPhone;
        private TextBox txbPhone;
        private Label lblSecretQuestionAnswer;
        private Label lblSecretQuestion;
        private TextBox txbSecretQuestion;
        private TextBox txbSecretQuestionAnswer;
        private Button btnReset;
    }
}
