namespace finite_state_machine
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
            this.btn_draw = new System.Windows.Forms.Button();
            this.txt_enter = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.accepting = new System.Windows.Forms.Label();
            this.btn_newFsm = new System.Windows.Forms.Button();
            this.txt_stateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stateX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stateY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addState = new System.Windows.Forms.Button();
            this.btn_addTransition = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pointedState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_positionState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_transitionVal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fsmName = new System.Windows.Forms.TextBox();
            this.cb_end = new System.Windows.Forms.CheckBox();
            this.btn_PreMadeFsm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(13, 13);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(75, 23);
            this.btn_draw.TabIndex = 0;
            this.btn_draw.Text = "Draw FSM";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // txt_enter
            // 
            this.txt_enter.Location = new System.Drawing.Point(104, 13);
            this.txt_enter.Name = "txt_enter";
            this.txt_enter.Size = new System.Drawing.Size(136, 20);
            this.txt_enter.TabIndex = 1;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(247, 13);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // accepting
            // 
            this.accepting.AutoSize = true;
            this.accepting.Location = new System.Drawing.Point(358, 13);
            this.accepting.Name = "accepting";
            this.accepting.Size = new System.Drawing.Size(0, 13);
            this.accepting.TabIndex = 3;
            // 
            // btn_newFsm
            // 
            this.btn_newFsm.Location = new System.Drawing.Point(755, 16);
            this.btn_newFsm.Name = "btn_newFsm";
            this.btn_newFsm.Size = new System.Drawing.Size(75, 23);
            this.btn_newFsm.TabIndex = 4;
            this.btn_newFsm.Text = "New FSM";
            this.btn_newFsm.UseVisualStyleBackColor = true;
            this.btn_newFsm.Click += new System.EventHandler(this.Btn_newFsm_Click);
            // 
            // txt_stateName
            // 
            this.txt_stateName.Location = new System.Drawing.Point(578, 42);
            this.txt_stateName.Name = "txt_stateName";
            this.txt_stateName.Size = new System.Drawing.Size(105, 20);
            this.txt_stateName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "state name";
            // 
            // txt_stateX
            // 
            this.txt_stateX.Location = new System.Drawing.Point(578, 69);
            this.txt_stateX.Name = "txt_stateX";
            this.txt_stateX.Size = new System.Drawing.Size(36, 20);
            this.txt_stateX.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "State X";
            // 
            // txt_stateY
            // 
            this.txt_stateY.Location = new System.Drawing.Point(681, 68);
            this.txt_stateY.Name = "txt_stateY";
            this.txt_stateY.Size = new System.Drawing.Size(32, 20);
            this.txt_stateY.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "State Y";
            // 
            // btn_addState
            // 
            this.btn_addState.Location = new System.Drawing.Point(578, 108);
            this.btn_addState.Name = "btn_addState";
            this.btn_addState.Size = new System.Drawing.Size(75, 23);
            this.btn_addState.TabIndex = 11;
            this.btn_addState.Text = "Add State";
            this.btn_addState.UseVisualStyleBackColor = true;
            this.btn_addState.Click += new System.EventHandler(this.Btn_addState_Click);
            // 
            // btn_addTransition
            // 
            this.btn_addTransition.Location = new System.Drawing.Point(578, 163);
            this.btn_addTransition.Name = "btn_addTransition";
            this.btn_addTransition.Size = new System.Drawing.Size(85, 23);
            this.btn_addTransition.TabIndex = 18;
            this.btn_addTransition.Text = "Add Transition";
            this.btn_addTransition.UseVisualStyleBackColor = true;
            this.btn_addTransition.Click += new System.EventHandler(this.Btn_addTransition_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "pointed State";
            // 
            // txt_pointedState
            // 
            this.txt_pointedState.Location = new System.Drawing.Point(785, 137);
            this.txt_pointedState.Name = "txt_pointedState";
            this.txt_pointedState.Size = new System.Drawing.Size(32, 20);
            this.txt_pointedState.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "positioned State";
            // 
            // txt_positionState
            // 
            this.txt_positionState.Location = new System.Drawing.Point(660, 137);
            this.txt_positionState.Name = "txt_positionState";
            this.txt_positionState.Size = new System.Drawing.Size(36, 20);
            this.txt_positionState.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Value";
            // 
            // txt_transitionVal
            // 
            this.txt_transitionVal.Location = new System.Drawing.Point(578, 137);
            this.txt_transitionVal.Name = "txt_transitionVal";
            this.txt_transitionVal.Size = new System.Drawing.Size(36, 20);
            this.txt_transitionVal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "FSM Name";
            // 
            // txt_fsmName
            // 
            this.txt_fsmName.Location = new System.Drawing.Point(578, 16);
            this.txt_fsmName.Name = "txt_fsmName";
            this.txt_fsmName.Size = new System.Drawing.Size(100, 20);
            this.txt_fsmName.TabIndex = 20;
            // 
            // cb_end
            // 
            this.cb_end.AutoSize = true;
            this.cb_end.Location = new System.Drawing.Point(785, 71);
            this.cb_end.Name = "cb_end";
            this.cb_end.Size = new System.Drawing.Size(107, 17);
            this.cb_end.TabIndex = 22;
            this.cb_end.Text = "accepting State?";
            this.cb_end.UseVisualStyleBackColor = true;
            // 
            // btn_PreMadeFsm
            // 
            this.btn_PreMadeFsm.Location = new System.Drawing.Point(849, 16);
            this.btn_PreMadeFsm.Name = "btn_PreMadeFsm";
            this.btn_PreMadeFsm.Size = new System.Drawing.Size(105, 23);
            this.btn_PreMadeFsm.TabIndex = 23;
            this.btn_PreMadeFsm.Text = "set premade FSM";
            this.btn_PreMadeFsm.UseVisualStyleBackColor = true;
            this.btn_PreMadeFsm.Click += new System.EventHandler(this.btn_PreMadeFsm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btn_PreMadeFsm);
            this.Controls.Add(this.cb_end);
            this.Controls.Add(this.txt_fsmName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_addTransition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pointedState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_positionState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_transitionVal);
            this.Controls.Add(this.btn_addState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_stateY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_stateX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stateName);
            this.Controls.Add(this.btn_newFsm);
            this.Controls.Add(this.accepting);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_enter);
            this.Controls.Add(this.btn_draw);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.TextBox txt_enter;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label accepting;
        private System.Windows.Forms.Button btn_newFsm;
        private System.Windows.Forms.TextBox txt_stateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stateX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stateY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addState;
        private System.Windows.Forms.Button btn_addTransition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pointedState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_positionState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_transitionVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fsmName;
        private System.Windows.Forms.CheckBox cb_end;
        private System.Windows.Forms.Button btn_PreMadeFsm;
    }
}

