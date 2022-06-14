
namespace Histogram_Ocen
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.bt_open_file = new System.Windows.Forms.Button();
            this.lbl_main_text = new System.Windows.Forms.Label();
            this.bt_show_graph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_open_file
            // 
            this.bt_open_file.BackColor = System.Drawing.Color.White;
            this.bt_open_file.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_open_file.Location = new System.Drawing.Point(25, 220);
            this.bt_open_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_open_file.Name = "bt_open_file";
            this.bt_open_file.Size = new System.Drawing.Size(150, 50);
            this.bt_open_file.TabIndex = 0;
            this.bt_open_file.Text = "Otwórz plik z danymi";
            this.bt_open_file.UseVisualStyleBackColor = false;
            this.bt_open_file.Click += new System.EventHandler(this.bt_open_file_Click);
            // 
            // lbl_main_text
            // 
            this.lbl_main_text.AutoSize = true;
            this.lbl_main_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_main_text.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_main_text.ForeColor = System.Drawing.Color.White;
            this.lbl_main_text.Location = new System.Drawing.Point(100, 10);
            this.lbl_main_text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_main_text.Name = "lbl_main_text";
            this.lbl_main_text.Size = new System.Drawing.Size(202, 45);
            this.lbl_main_text.TabIndex = 1;
            this.lbl_main_text.Text = "Histogram";
            // 
            // bt_show_graph
            // 
            this.bt_show_graph.BackColor = System.Drawing.Color.White;
            this.bt_show_graph.Enabled = false;
            this.bt_show_graph.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_show_graph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_show_graph.Location = new System.Drawing.Point(25, 280);
            this.bt_show_graph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_show_graph.Name = "bt_show_graph";
            this.bt_show_graph.Size = new System.Drawing.Size(150, 50);
            this.bt_show_graph.TabIndex = 2;
            this.bt_show_graph.Text = "Pokaż histogram";
            this.bt_show_graph.UseVisualStyleBackColor = false;
            this.bt_show_graph.Click += new System.EventHandler(this.bt_show_graph_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.bt_show_graph);
            this.Controls.Add(this.lbl_main_text);
            this.Controls.Add(this.bt_open_file);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "Histogram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_open_file;
        private System.Windows.Forms.Label lbl_main_text;
        private System.Windows.Forms.Button bt_show_graph;
    }
}

