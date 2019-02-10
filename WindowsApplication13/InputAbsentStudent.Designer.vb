<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputAbsentStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputAbsentStudent))
        Me.DelBut = New System.Windows.Forms.Button()
        Me.TotalPermit = New System.Windows.Forms.TextBox()
        Me.TtlPermit = New System.Windows.Forms.Label()
        Me.TotalSick = New System.Windows.Forms.TextBox()
        Me.Classroom = New System.Windows.Forms.TextBox()
        Me.TtlSickLBL = New System.Windows.Forms.Label()
        Me.NamStu = New System.Windows.Forms.TextBox()
        Me.QuitBut = New System.Windows.Forms.Button()
        Me.TblSaveMoneyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveBut = New System.Windows.Forms.Button()
        Me.TotalAbsentView = New System.Windows.Forms.DataGridView()
        Me.NameStudentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassroomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalSickDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPermitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNodescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPresentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblabsentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_ControlStudentDataSet = New WindowsApplication13.db_ControlStudentDataSet()
        Me.ClassLBL = New System.Windows.Forms.Label()
        Me.NamStuLBL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TotalPresent = New System.Windows.Forms.TextBox()
        Me.TttlPresent = New System.Windows.Forms.Label()
        Me.TotalNoDesc = New System.Windows.Forms.TextBox()
        Me.TttlNoDesc = New System.Windows.Forms.Label()
        Me.Tbl_absentTableAdapter = New WindowsApplication13.db_ControlStudentDataSetTableAdapters.tbl_absentTableAdapter()
        CType(Me.TblSaveMoneyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAbsentView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblabsentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_ControlStudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DelBut
        '
        Me.DelBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBut.Location = New System.Drawing.Point(154, 401)
        Me.DelBut.Name = "DelBut"
        Me.DelBut.Size = New System.Drawing.Size(96, 58)
        Me.DelBut.TabIndex = 20
        Me.DelBut.Text = "Delete"
        Me.DelBut.UseVisualStyleBackColor = True
        '
        'TotalPermit
        '
        Me.TotalPermit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPermit.Location = New System.Drawing.Point(138, 219)
        Me.TotalPermit.Name = "TotalPermit"
        Me.TotalPermit.Size = New System.Drawing.Size(57, 26)
        Me.TotalPermit.TabIndex = 19
        '
        'TtlPermit
        '
        Me.TtlPermit.AutoSize = True
        Me.TtlPermit.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TtlPermit.Location = New System.Drawing.Point(6, 219)
        Me.TtlPermit.Name = "TtlPermit"
        Me.TtlPermit.Size = New System.Drawing.Size(126, 21)
        Me.TtlPermit.TabIndex = 18
        Me.TtlPermit.Text = "Total Permit :"
        '
        'TotalSick
        '
        Me.TotalSick.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSick.Location = New System.Drawing.Point(120, 162)
        Me.TotalSick.Name = "TotalSick"
        Me.TotalSick.Size = New System.Drawing.Size(57, 26)
        Me.TotalSick.TabIndex = 17
        '
        'Classroom
        '
        Me.Classroom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classroom.Location = New System.Drawing.Point(120, 108)
        Me.Classroom.Name = "Classroom"
        Me.Classroom.Size = New System.Drawing.Size(242, 26)
        Me.Classroom.TabIndex = 15
        '
        'TtlSickLBL
        '
        Me.TtlSickLBL.AutoSize = True
        Me.TtlSickLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TtlSickLBL.Location = New System.Drawing.Point(6, 157)
        Me.TtlSickLBL.Name = "TtlSickLBL"
        Me.TtlSickLBL.Size = New System.Drawing.Size(101, 21)
        Me.TtlSickLBL.TabIndex = 16
        Me.TtlSickLBL.Text = "Total Sick :"
        '
        'NamStu
        '
        Me.NamStu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamStu.Location = New System.Drawing.Point(153, 25)
        Me.NamStu.Name = "NamStu"
        Me.NamStu.Size = New System.Drawing.Size(192, 26)
        Me.NamStu.TabIndex = 14
        '
        'QuitBut
        '
        Me.QuitBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBut.Location = New System.Drawing.Point(294, 401)
        Me.QuitBut.Name = "QuitBut"
        Me.QuitBut.Size = New System.Drawing.Size(96, 58)
        Me.QuitBut.TabIndex = 13
        Me.QuitBut.Text = "Quit"
        Me.QuitBut.UseVisualStyleBackColor = True
        '
        'TblSaveMoneyBindingSource
        '
        Me.TblSaveMoneyBindingSource.DataMember = "tbl_SaveMoney"
        '
        'SaveBut
        '
        Me.SaveBut.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBut.Location = New System.Drawing.Point(11, 401)
        Me.SaveBut.Name = "SaveBut"
        Me.SaveBut.Size = New System.Drawing.Size(99, 58)
        Me.SaveBut.TabIndex = 12
        Me.SaveBut.Text = "Save"
        Me.SaveBut.UseVisualStyleBackColor = True
        '
        'TotalAbsentView
        '
        Me.TotalAbsentView.AutoGenerateColumns = False
        Me.TotalAbsentView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TotalAbsentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotalAbsentView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameStudentDataGridViewTextBoxColumn, Me.ClassroomDataGridViewTextBoxColumn, Me.TotalSickDataGridViewTextBoxColumn, Me.TotalPermitDataGridViewTextBoxColumn, Me.TotalNodescriptionDataGridViewTextBoxColumn, Me.TotalPresentDataGridViewTextBoxColumn})
        Me.TotalAbsentView.DataSource = Me.TblabsentBindingSource
        Me.TotalAbsentView.GridColor = System.Drawing.Color.Salmon
        Me.TotalAbsentView.Location = New System.Drawing.Point(476, 12)
        Me.TotalAbsentView.Name = "TotalAbsentView"
        Me.TotalAbsentView.Size = New System.Drawing.Size(682, 203)
        Me.TotalAbsentView.TabIndex = 3
        '
        'NameStudentDataGridViewTextBoxColumn
        '
        Me.NameStudentDataGridViewTextBoxColumn.DataPropertyName = "Name_Student"
        Me.NameStudentDataGridViewTextBoxColumn.HeaderText = "Name_Student"
        Me.NameStudentDataGridViewTextBoxColumn.Name = "NameStudentDataGridViewTextBoxColumn"
        '
        'ClassroomDataGridViewTextBoxColumn
        '
        Me.ClassroomDataGridViewTextBoxColumn.DataPropertyName = "Classroom"
        Me.ClassroomDataGridViewTextBoxColumn.HeaderText = "Classroom"
        Me.ClassroomDataGridViewTextBoxColumn.Name = "ClassroomDataGridViewTextBoxColumn"
        '
        'TotalSickDataGridViewTextBoxColumn
        '
        Me.TotalSickDataGridViewTextBoxColumn.DataPropertyName = "Total_Sick"
        Me.TotalSickDataGridViewTextBoxColumn.HeaderText = "Total_Sick"
        Me.TotalSickDataGridViewTextBoxColumn.Name = "TotalSickDataGridViewTextBoxColumn"
        '
        'TotalPermitDataGridViewTextBoxColumn
        '
        Me.TotalPermitDataGridViewTextBoxColumn.DataPropertyName = "Total_Permit"
        Me.TotalPermitDataGridViewTextBoxColumn.HeaderText = "Total_Permit"
        Me.TotalPermitDataGridViewTextBoxColumn.Name = "TotalPermitDataGridViewTextBoxColumn"
        '
        'TotalNodescriptionDataGridViewTextBoxColumn
        '
        Me.TotalNodescriptionDataGridViewTextBoxColumn.DataPropertyName = "Total_Nodescription"
        Me.TotalNodescriptionDataGridViewTextBoxColumn.HeaderText = "Total_Nodescription"
        Me.TotalNodescriptionDataGridViewTextBoxColumn.Name = "TotalNodescriptionDataGridViewTextBoxColumn"
        '
        'TotalPresentDataGridViewTextBoxColumn
        '
        Me.TotalPresentDataGridViewTextBoxColumn.DataPropertyName = "Total_Present"
        Me.TotalPresentDataGridViewTextBoxColumn.HeaderText = "Total_Present"
        Me.TotalPresentDataGridViewTextBoxColumn.Name = "TotalPresentDataGridViewTextBoxColumn"
        '
        'TblabsentBindingSource
        '
        Me.TblabsentBindingSource.DataMember = "tbl_absent"
        Me.TblabsentBindingSource.DataSource = Me.Db_ControlStudentDataSet
        '
        'Db_ControlStudentDataSet
        '
        Me.Db_ControlStudentDataSet.DataSetName = "db_ControlStudentDataSet"
        Me.Db_ControlStudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassLBL
        '
        Me.ClassLBL.AutoSize = True
        Me.ClassLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassLBL.Location = New System.Drawing.Point(6, 103)
        Me.ClassLBL.Name = "ClassLBL"
        Me.ClassLBL.Size = New System.Drawing.Size(103, 21)
        Me.ClassLBL.TabIndex = 11
        Me.ClassLBL.Text = "Classroom :"
        '
        'NamStuLBL
        '
        Me.NamStuLBL.AutoSize = True
        Me.NamStuLBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamStuLBL.Location = New System.Drawing.Point(6, 27)
        Me.NamStuLBL.Name = "NamStuLBL"
        Me.NamStuLBL.Size = New System.Drawing.Size(141, 21)
        Me.NamStuLBL.TabIndex = 10
        Me.NamStuLBL.Text = "Name Student :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.TotalPresent)
        Me.GroupBox1.Controls.Add(Me.TttlPresent)
        Me.GroupBox1.Controls.Add(Me.TotalNoDesc)
        Me.GroupBox1.Controls.Add(Me.TttlNoDesc)
        Me.GroupBox1.Controls.Add(Me.DelBut)
        Me.GroupBox1.Controls.Add(Me.TotalPermit)
        Me.GroupBox1.Controls.Add(Me.TtlPermit)
        Me.GroupBox1.Controls.Add(Me.TotalSick)
        Me.GroupBox1.Controls.Add(Me.Classroom)
        Me.GroupBox1.Controls.Add(Me.TtlSickLBL)
        Me.GroupBox1.Controls.Add(Me.NamStu)
        Me.GroupBox1.Controls.Add(Me.QuitBut)
        Me.GroupBox1.Controls.Add(Me.SaveBut)
        Me.GroupBox1.Controls.Add(Me.ClassLBL)
        Me.GroupBox1.Controls.Add(Me.NamStuLBL)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 527)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TotalPresent
        '
        Me.TotalPresent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPresent.Location = New System.Drawing.Point(148, 336)
        Me.TotalPresent.Name = "TotalPresent"
        Me.TotalPresent.Size = New System.Drawing.Size(57, 26)
        Me.TotalPresent.TabIndex = 24
        '
        'TttlPresent
        '
        Me.TttlPresent.AutoSize = True
        Me.TttlPresent.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TttlPresent.Location = New System.Drawing.Point(11, 336)
        Me.TttlPresent.Name = "TttlPresent"
        Me.TttlPresent.Size = New System.Drawing.Size(131, 21)
        Me.TttlPresent.TabIndex = 23
        Me.TttlPresent.Text = "Total Present :"
        '
        'TotalNoDesc
        '
        Me.TotalNoDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNoDesc.Location = New System.Drawing.Point(214, 278)
        Me.TotalNoDesc.Name = "TotalNoDesc"
        Me.TotalNoDesc.Size = New System.Drawing.Size(57, 26)
        Me.TotalNoDesc.TabIndex = 22
        '
        'TttlNoDesc
        '
        Me.TttlNoDesc.AutoSize = True
        Me.TttlNoDesc.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TttlNoDesc.Location = New System.Drawing.Point(11, 278)
        Me.TttlNoDesc.Name = "TttlNoDesc"
        Me.TttlNoDesc.Size = New System.Drawing.Size(197, 21)
        Me.TttlNoDesc.TabIndex = 21
        Me.TttlNoDesc.Text = "Total No Description :"
        '
        'Tbl_absentTableAdapter
        '
        Me.Tbl_absentTableAdapter.ClearBeforeFill = True
        '
        'InputAbsentStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1184, 532)
        Me.Controls.Add(Me.TotalAbsentView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InputAbsentStudent"
        Me.Text = "InputAbsentStudent"
        CType(Me.TblSaveMoneyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAbsentView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblabsentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_ControlStudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DelBut As Button
    Friend WithEvents TotalPermit As TextBox
    Friend WithEvents TtlPermit As Label
    Friend WithEvents TotalSick As TextBox
    Friend WithEvents Classroom As TextBox
    Friend WithEvents TtlSickLBL As Label
    Friend WithEvents NamStu As TextBox
    Friend WithEvents QuitBut As Button
    Friend WithEvents TblSaveMoneyBindingSource As BindingSource
    Friend WithEvents SaveBut As Button
    Friend WithEvents TotalAbsentView As DataGridView
    Friend WithEvents ClassLBL As Label
    Friend WithEvents NamStuLBL As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TotalNoDesc As TextBox
    Friend WithEvents TttlNoDesc As Label
    Friend WithEvents TotalPresent As TextBox
    Friend WithEvents TttlPresent As Label
    Friend WithEvents Db_ControlStudentDataSet As db_ControlStudentDataSet
    Friend WithEvents TblabsentBindingSource As BindingSource
    Friend WithEvents Tbl_absentTableAdapter As db_ControlStudentDataSetTableAdapters.tbl_absentTableAdapter
    Friend WithEvents NameStudentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassroomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalSickDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPermitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalNodescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPresentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
