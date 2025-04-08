namespace P.II_C.II_SI_Actores_y_Series {
    partial class MainWindow {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            btActors=new Button();
            btSeries=new Button();
            SuspendLayout();
            // 
            // btActors
            // 
            btActors.BackColor=Color.LimeGreen;
            btActors.Location=new Point(160, 79);
            btActors.Name="btActors";
            btActors.Size=new Size(141, 56);
            btActors.TabIndex=0;
            btActors.Text="Actores/Actrices";
            btActors.UseVisualStyleBackColor=false;
            btActors.Click+=btActors_Click;
            // 
            // btSeries
            // 
            btSeries.BackColor=Color.LimeGreen;
            btSeries.Location=new Point(160, 177);
            btSeries.Name="btSeries";
            btSeries.Size=new Size(141, 56);
            btSeries.TabIndex=1;
            btSeries.Text="Series";
            btSeries.UseVisualStyleBackColor=false;
            btSeries.Click+=btSeries_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Green;
            ClientSize=new Size(469, 317);
            Controls.Add(btSeries);
            Controls.Add(btActors);
            Name="MainWindow";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form1";
            Load+=MainWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btActors;
        private Button btSeries;
    }
}
