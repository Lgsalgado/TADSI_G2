namespace Proyecto_JC_Distribuidres_2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombreMaterial = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.materialesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.materialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecProDataSet = new Proyecto_JC_Distribuidres_2.tecProDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materialesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.materialesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.idMaterialTextBox = new System.Windows.Forms.TextBox();
            this.nomMaterialTextBox = new System.Windows.Forms.TextBox();
            this.tamMaterialTextBox = new System.Windows.Forms.TextBox();
            this.tipoMaterialTextBox = new System.Windows.Forms.TextBox();
            this.cantMaterialTextBox = new System.Windows.Forms.TextBox();
            this.descMaterialTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialesTableAdapter = new Proyecto_JC_Distribuidres_2.tecProDataSetTableAdapters.materialesTableAdapter();
            this.tableAdapterManager = new Proyecto_JC_Distribuidres_2.tecProDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingNavigator)).BeginInit();
            this.materialesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecProDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE MATERIALES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(427, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombreMaterial
            // 
            this.lblNombreMaterial.AutoSize = true;
            this.lblNombreMaterial.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaterial.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombreMaterial.Location = new System.Drawing.Point(9, 77);
            this.lblNombreMaterial.Name = "lblNombreMaterial";
            this.lblNombreMaterial.Size = new System.Drawing.Size(134, 16);
            this.lblNombreMaterial.TabIndex = 3;
            this.lblNombreMaterial.Text = "Nombre del Material";
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamano.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTamano.Location = new System.Drawing.Point(12, 112);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(58, 16);
            this.lblTamano.TabIndex = 4;
            this.lblTamano.Text = "Tamaño";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTipo.Location = new System.Drawing.Point(12, 160);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(108, 16);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo de Material";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCantidad.Location = new System.Drawing.Point(12, 205);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(65, 16);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 249);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(427, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // materialesBindingNavigator
            // 
            this.materialesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.materialesBindingNavigator.BindingSource = this.materialesBindingSource;
            this.materialesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materialesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.materialesBindingNavigatorSaveItem});
            this.materialesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialesBindingNavigator.Name = "materialesBindingNavigator";
            this.materialesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialesBindingNavigator.Size = new System.Drawing.Size(863, 25);
            this.materialesBindingNavigator.TabIndex = 14;
            this.materialesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // materialesBindingSource
            // 
            this.materialesBindingSource.DataMember = "materiales";
            this.materialesBindingSource.DataSource = this.tecProDataSet;
            // 
            // tecProDataSet
            // 
            this.tecProDataSet.DataSetName = "tecProDataSet";
            this.tecProDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // materialesBindingNavigatorSaveItem
            // 
            this.materialesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("materialesBindingNavigatorSaveItem.Image")));
            this.materialesBindingNavigatorSaveItem.Name = "materialesBindingNavigatorSaveItem";
            this.materialesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.materialesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.materialesBindingNavigatorSaveItem.Click += new System.EventHandler(this.MaterialesBindingNavigatorSaveItem_Click);
            // 
            // materialesDataGridView
            // 
            this.materialesDataGridView.AutoGenerateColumns = false;
            this.materialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.materialesDataGridView.DataSource = this.materialesBindingSource;
            this.materialesDataGridView.Location = new System.Drawing.Point(12, 305);
            this.materialesDataGridView.Name = "materialesDataGridView";
            this.materialesDataGridView.Size = new System.Drawing.Size(645, 220);
            this.materialesDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idMaterial";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomMaterial";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tamMaterial";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tamaño";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tipoMaterial";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantMaterial";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descMaterial";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(427, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(427, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "eliminar ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(427, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // idMaterialTextBox
            // 
            this.idMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "idMaterial", true));
            this.idMaterialTextBox.Location = new System.Drawing.Point(162, 42);
            this.idMaterialTextBox.Name = "idMaterialTextBox";
            this.idMaterialTextBox.Size = new System.Drawing.Size(174, 20);
            this.idMaterialTextBox.TabIndex = 19;
            this.idMaterialTextBox.TextChanged += new System.EventHandler(this.IdMaterialTextBox_TextChanged);
            // 
            // nomMaterialTextBox
            // 
            this.nomMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "nomMaterial", true));
            this.nomMaterialTextBox.Location = new System.Drawing.Point(162, 73);
            this.nomMaterialTextBox.Name = "nomMaterialTextBox";
            this.nomMaterialTextBox.Size = new System.Drawing.Size(174, 20);
            this.nomMaterialTextBox.TabIndex = 21;
            // 
            // tamMaterialTextBox
            // 
            this.tamMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "tamMaterial", true));
            this.tamMaterialTextBox.Location = new System.Drawing.Point(162, 111);
            this.tamMaterialTextBox.Name = "tamMaterialTextBox";
            this.tamMaterialTextBox.Size = new System.Drawing.Size(174, 20);
            this.tamMaterialTextBox.TabIndex = 23;
            this.tamMaterialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TamMaterialTextBox_KeyPress);
            // 
            // tipoMaterialTextBox
            // 
            this.tipoMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "tipoMaterial", true));
            this.tipoMaterialTextBox.Location = new System.Drawing.Point(162, 156);
            this.tipoMaterialTextBox.Name = "tipoMaterialTextBox";
            this.tipoMaterialTextBox.Size = new System.Drawing.Size(174, 20);
            this.tipoMaterialTextBox.TabIndex = 25;
            // 
            // cantMaterialTextBox
            // 
            this.cantMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "cantMaterial", true));
            this.cantMaterialTextBox.Location = new System.Drawing.Point(162, 200);
            this.cantMaterialTextBox.Name = "cantMaterialTextBox";
            this.cantMaterialTextBox.Size = new System.Drawing.Size(174, 20);
            this.cantMaterialTextBox.TabIndex = 27;
            this.cantMaterialTextBox.TextChanged += new System.EventHandler(this.CantMaterialTextBox_TextChanged);
            this.cantMaterialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantMaterialTextBox_KeyPress);
            // 
            // descMaterialTextBox
            // 
            this.descMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "descMaterial", true));
            this.descMaterialTextBox.Location = new System.Drawing.Point(162, 245);
            this.descMaterialTextBox.Name = "descMaterialTextBox";
            this.descMaterialTextBox.Size = new System.Drawing.Size(174, 20);
            this.descMaterialTextBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Id Material";
            // 
            // materialesTableAdapter
            // 
            this.materialesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.facturaTableAdapter = null;
            this.tableAdapterManager.materialesTableAdapter = this.materialesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_JC_Distribuidres_2.tecProDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(863, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idMaterialTextBox);
            this.Controls.Add(this.nomMaterialTextBox);
            this.Controls.Add(this.tamMaterialTextBox);
            this.Controls.Add(this.tipoMaterialTextBox);
            this.Controls.Add(this.cantMaterialTextBox);
            this.Controls.Add(this.descMaterialTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.materialesDataGridView);
            this.Controls.Add(this.materialesBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.lblNombreMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingNavigator)).EndInit();
            this.materialesBindingNavigator.ResumeLayout(false);
            this.materialesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecProDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombreMaterial;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button button2;
        private tecProDataSet tecProDataSet;
        private System.Windows.Forms.BindingSource materialesBindingSource;
        private tecProDataSetTableAdapters.materialesTableAdapter materialesTableAdapter;
        private tecProDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton materialesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView materialesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox idMaterialTextBox;
        private System.Windows.Forms.TextBox nomMaterialTextBox;
        private System.Windows.Forms.TextBox tamMaterialTextBox;
        private System.Windows.Forms.TextBox tipoMaterialTextBox;
        private System.Windows.Forms.TextBox cantMaterialTextBox;
        private System.Windows.Forms.TextBox descMaterialTextBox;
        private System.Windows.Forms.Label label2;
    }
}