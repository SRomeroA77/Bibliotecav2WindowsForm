namespace Bibliotecav2.WinForm
{
    partial class Form1
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
            btnMostrarTodosLibros = new Button();
            label1 = new Label();
            listaGeneros = new ComboBox();
            libro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            autor = new TextBox();
            label4 = new Label();
            anni = new TextBox();
            label5 = new Label();
            btnIngresar = new Button();
            boxListaLibros = new ListBox();
            librosParaEliminar = new ComboBox();
            EliminarLibro = new Button();
            label6 = new Label();
            btnUpdate = new Button();
            label7 = new Label();
            label8 = new Label();
            annioUpdate = new TextBox();
            label9 = new Label();
            autorUpdate = new TextBox();
            label10 = new Label();
            libroUpdate = new TextBox();
            listaGenerosUpdate = new ComboBox();
            label11 = new Label();
            listaLibrosActualizar = new ComboBox();
            SelectUpdate = new Button();
            SuspendLayout();
            // 
            // btnMostrarTodosLibros
            // 
            btnMostrarTodosLibros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrarTodosLibros.Location = new Point(1001, 77);
            btnMostrarTodosLibros.Name = "btnMostrarTodosLibros";
            btnMostrarTodosLibros.Size = new Size(183, 61);
            btnMostrarTodosLibros.TabIndex = 0;
            btnMostrarTodosLibros.Text = "Mostrar Libros";
            btnMostrarTodosLibros.UseVisualStyleBackColor = true;
            btnMostrarTodosLibros.Click += btnMostrarTodosLibros_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(466, 86);
            label1.Name = "label1";
            label1.Size = new Size(457, 38);
            label1.TabIndex = 1;
            label1.Text = "Mostrar todos los libros disponibles";
            // 
            // listaGeneros
            // 
            listaGeneros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listaGeneros.FormattingEnabled = true;
            listaGeneros.Items.AddRange(new object[] { "Fantasía", "Terror", "Comedia", "Drama", "Ciencia Ficción", "No identificado" });
            listaGeneros.Location = new Point(727, 247);
            listaGeneros.Name = "listaGeneros";
            listaGeneros.Size = new Size(182, 40);
            listaGeneros.TabIndex = 2;
            // 
            // libro
            // 
            libro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libro.Location = new Point(156, 167);
            libro.Name = "libro";
            libro.Size = new Size(359, 39);
            libro.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 164);
            label2.Name = "label2";
            label2.Size = new Size(85, 38);
            label2.TabIndex = 4;
            label2.Text = "Libro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 242);
            label3.Name = "label3";
            label3.Size = new Size(92, 38);
            label3.TabIndex = 6;
            label3.Text = "Autor:";
            // 
            // autor
            // 
            autor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            autor.Location = new Point(156, 244);
            autor.Name = "autor";
            autor.Size = new Size(359, 39);
            autor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(554, 167);
            label4.Name = "label4";
            label4.Size = new Size(73, 38);
            label4.TabIndex = 8;
            label4.Text = "Año:";
            // 
            // anni
            // 
            anni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            anni.Location = new Point(727, 167);
            anni.Name = "anni";
            anni.Size = new Size(182, 39);
            anni.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(554, 245);
            label5.Name = "label5";
            label5.Size = new Size(114, 38);
            label5.TabIndex = 9;
            label5.Text = "Género:";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(1001, 202);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(183, 61);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar Libro";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // boxListaLibros
            // 
            boxListaLibros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxListaLibros.FormattingEnabled = true;
            boxListaLibros.ItemHeight = 32;
            boxListaLibros.Location = new Point(33, 691);
            boxListaLibros.Name = "boxListaLibros";
            boxListaLibros.Size = new Size(1174, 292);
            boxListaLibros.TabIndex = 11;
            // 
            // librosParaEliminar
            // 
            librosParaEliminar.FormattingEnabled = true;
            librosParaEliminar.Location = new Point(52, 600);
            librosParaEliminar.Name = "librosParaEliminar";
            librosParaEliminar.Size = new Size(890, 33);
            librosParaEliminar.TabIndex = 12;
            librosParaEliminar.SelectedIndexChanged += librosParaEliminar_SelectedIndexChanged;
            // 
            // EliminarLibro
            // 
            EliminarLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EliminarLibro.Location = new Point(982, 577);
            EliminarLibro.Name = "EliminarLibro";
            EliminarLibro.Size = new Size(225, 61);
            EliminarLibro.TabIndex = 13;
            EliminarLibro.Text = "Libro a Eliminar";
            EliminarLibro.UseVisualStyleBackColor = true;
            EliminarLibro.Click += EliminarLibro_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 539);
            label6.Name = "label6";
            label6.Size = new Size(505, 38);
            label6.TabIndex = 14;
            label6.Text = "Selecciona Título de libro para eliminar:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(1001, 441);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 81);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Actualizar Libro";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(554, 498);
            label7.Name = "label7";
            label7.Size = new Size(114, 38);
            label7.TabIndex = 22;
            label7.Text = "Género:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(554, 420);
            label8.Name = "label8";
            label8.Size = new Size(73, 38);
            label8.TabIndex = 21;
            label8.Text = "Año:";
            // 
            // annioUpdate
            // 
            annioUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            annioUpdate.Location = new Point(727, 420);
            annioUpdate.Name = "annioUpdate";
            annioUpdate.Size = new Size(182, 39);
            annioUpdate.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 495);
            label9.Name = "label9";
            label9.Size = new Size(92, 38);
            label9.TabIndex = 19;
            label9.Text = "Autor:";
            // 
            // autorUpdate
            // 
            autorUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            autorUpdate.Location = new Point(156, 497);
            autorUpdate.Name = "autorUpdate";
            autorUpdate.Size = new Size(359, 39);
            autorUpdate.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(33, 417);
            label10.Name = "label10";
            label10.Size = new Size(85, 38);
            label10.TabIndex = 17;
            label10.Text = "Libro:";
            // 
            // libroUpdate
            // 
            libroUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libroUpdate.Location = new Point(156, 420);
            libroUpdate.Name = "libroUpdate";
            libroUpdate.Size = new Size(359, 39);
            libroUpdate.TabIndex = 16;
            // 
            // listaGenerosUpdate
            // 
            listaGenerosUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listaGenerosUpdate.FormattingEnabled = true;
            listaGenerosUpdate.Items.AddRange(new object[] { "Fantasía", "Terror", "Comedia", "Drama", "Ciencia Ficción", "No identificado" });
            listaGenerosUpdate.Location = new Point(727, 500);
            listaGenerosUpdate.Name = "listaGenerosUpdate";
            listaGenerosUpdate.Size = new Size(182, 40);
            listaGenerosUpdate.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(33, 307);
            label11.Name = "label11";
            label11.Size = new Size(522, 38);
            label11.TabIndex = 24;
            label11.Text = "Selecciona Título de libro para actualizar:";
            // 
            // listaLibrosActualizar
            // 
            listaLibrosActualizar.FormattingEnabled = true;
            listaLibrosActualizar.Location = new Point(52, 357);
            listaLibrosActualizar.Name = "listaLibrosActualizar";
            listaLibrosActualizar.Size = new Size(890, 33);
            listaLibrosActualizar.TabIndex = 25;
            // 
            // SelectUpdate
            // 
            SelectUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectUpdate.Location = new Point(1001, 340);
            SelectUpdate.Name = "SelectUpdate";
            SelectUpdate.Size = new Size(183, 72);
            SelectUpdate.TabIndex = 26;
            SelectUpdate.Text = "Seleccionar libro";
            SelectUpdate.UseVisualStyleBackColor = true;
            SelectUpdate.Click += SelectUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 1017);
            Controls.Add(SelectUpdate);
            Controls.Add(listaLibrosActualizar);
            Controls.Add(label11);
            Controls.Add(btnUpdate);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(annioUpdate);
            Controls.Add(label9);
            Controls.Add(autorUpdate);
            Controls.Add(label10);
            Controls.Add(libroUpdate);
            Controls.Add(listaGenerosUpdate);
            Controls.Add(label6);
            Controls.Add(EliminarLibro);
            Controls.Add(librosParaEliminar);
            Controls.Add(boxListaLibros);
            Controls.Add(btnIngresar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(anni);
            Controls.Add(label3);
            Controls.Add(autor);
            Controls.Add(label2);
            Controls.Add(libro);
            Controls.Add(listaGeneros);
            Controls.Add(label1);
            Controls.Add(btnMostrarTodosLibros);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarTodosLibros;
        private Label label1;
        private ComboBox listaGeneros;
        private TextBox libro;
        private Label label2;
        private Label label3;
        private TextBox autor;
        private Label label4;
        private TextBox anni;
        private Label label5;
        private Button btnIngresar;
        private ListBox boxListaLibros;
        private ComboBox librosParaEliminar;
        private Button EliminarLibro;
        private Label label6;
        private Button btnUpdate;
        private Label label7;
        private Label label8;
        private TextBox annioUpdate;
        private Label label9;
        private TextBox autorUpdate;
        private Label label10;
        private TextBox libroUpdate;
        private ComboBox listaGenerosUpdate;
        private Label label11;
        private ComboBox listaLibrosActualizar;
        private Button SelectUpdate;
    }
}