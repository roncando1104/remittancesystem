<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManagedCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManagedCustomers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TvCustomerName = New System.Windows.Forms.TextBox()
        Me.dgvSpecificCustomerTransactions = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFindCustName = New System.Windows.Forms.Button()
        Me.BtnDeleteSpecificCustRecords = New System.Windows.Forms.Button()
        Me.TxtRefNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvSpecificCustomerTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'TvCustomerName
        '
        Me.TvCustomerName.Location = New System.Drawing.Point(166, 51)
        Me.TvCustomerName.Name = "TvCustomerName"
        Me.TvCustomerName.Size = New System.Drawing.Size(248, 20)
        Me.TvCustomerName.TabIndex = 1
        '
        'dgvSpecificCustomerTransactions
        '
        Me.dgvSpecificCustomerTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSpecificCustomerTransactions.Location = New System.Drawing.Point(12, 116)
        Me.dgvSpecificCustomerTransactions.Name = "dgvSpecificCustomerTransactions"
        Me.dgvSpecificCustomerTransactions.Size = New System.Drawing.Size(990, 191)
        Me.dgvSpecificCustomerTransactions.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(28, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "All Transaction From Customer:"
        '
        'BtnFindCustName
        '
        Me.BtnFindCustName.BackColor = System.Drawing.Color.Turquoise
        Me.BtnFindCustName.FlatAppearance.BorderSize = 0
        Me.BtnFindCustName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindCustName.Image = CType(resources.GetObject("BtnFindCustName.Image"), System.Drawing.Image)
        Me.BtnFindCustName.Location = New System.Drawing.Point(414, 50)
        Me.BtnFindCustName.Name = "BtnFindCustName"
        Me.BtnFindCustName.Size = New System.Drawing.Size(36, 23)
        Me.BtnFindCustName.TabIndex = 4
        Me.BtnFindCustName.UseVisualStyleBackColor = False
        '
        'BtnDeleteSpecificCustRecords
        '
        Me.BtnDeleteSpecificCustRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteSpecificCustRecords.Image = CType(resources.GetObject("BtnDeleteSpecificCustRecords.Image"), System.Drawing.Image)
        Me.BtnDeleteSpecificCustRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeleteSpecificCustRecords.Location = New System.Drawing.Point(12, 409)
        Me.BtnDeleteSpecificCustRecords.Name = "BtnDeleteSpecificCustRecords"
        Me.BtnDeleteSpecificCustRecords.Size = New System.Drawing.Size(227, 46)
        Me.BtnDeleteSpecificCustRecords.TabIndex = 5
        Me.BtnDeleteSpecificCustRecords.Text = "DELETE CUSTOMER RECORDS"
        Me.BtnDeleteSpecificCustRecords.UseVisualStyleBackColor = True
        '
        'TxtRefNumber
        '
        Me.TxtRefNumber.Location = New System.Drawing.Point(12, 357)
        Me.TxtRefNumber.Name = "TxtRefNumber"
        Me.TxtRefNumber.Size = New System.Drawing.Size(248, 20)
        Me.TxtRefNumber.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter Reference Number:"
        '
        'FormManagedCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 484)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtRefNumber)
        Me.Controls.Add(Me.BtnDeleteSpecificCustRecords)
        Me.Controls.Add(Me.BtnFindCustName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvSpecificCustomerTransactions)
        Me.Controls.Add(Me.TvCustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormManagedCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER INFORMATION MANAGEMENT"
        CType(Me.dgvSpecificCustomerTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TvCustomerName As TextBox
    Friend WithEvents dgvSpecificCustomerTransactions As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFindCustName As Button
    Friend WithEvents BtnDeleteSpecificCustRecords As Button
    Friend WithEvents TxtRefNumber As TextBox
    Friend WithEvents Label3 As Label
End Class
