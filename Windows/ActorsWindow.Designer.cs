namespace P.II_C.II_SI_Actores_y_Series.Windows {
    partial class ActorsWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            SuspendLayout();
            // 
            // ActorsWindow
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Green;
            ClientSize=new Size(465, 590);
            Name="ActorsWindow";
            StartPosition=FormStartPosition.CenterScreen;
            Text="ActorsForm";
            Load+=ActorsForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}