<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashBoard
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
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashBoard))
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.BtnAddChart = New System.Windows.Forms.Button()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLogout = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.LightGray
        ChartArea10.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend10)
        Me.Chart1.Location = New System.Drawing.Point(12, 128)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chart1.Size = New System.Drawing.Size(419, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(585, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DASHBOARD"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDate.Location = New System.Drawing.Point(1046, 45)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(48, 20)
        Me.LabelDate.TabIndex = 13
        Me.LabelDate.Text = "DATE:"
        '
        'BtnAddChart
        '
        Me.BtnAddChart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAddChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddChart.Image = CType(resources.GetObject("BtnAddChart.Image"), System.Drawing.Image)
        Me.BtnAddChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddChart.Location = New System.Drawing.Point(590, 460)
        Me.BtnAddChart.Name = "BtnAddChart"
        Me.BtnAddChart.Size = New System.Drawing.Size(203, 43)
        Me.BtnAddChart.TabIndex = 1
        Me.BtnAddChart.Text = "GENERATE CHARTS"
        Me.BtnAddChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddChart.UseVisualStyleBackColor = False
        '
        'Chart4
        '
        Me.Chart4.BackColor = System.Drawing.Color.LightGray
        ChartArea11.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend11)
        Me.Chart4.Location = New System.Drawing.Point(460, 128)
        Me.Chart4.Name = "Chart4"
        Me.Chart4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chart4.Size = New System.Drawing.Size(423, 300)
        Me.Chart4.TabIndex = 20
        Me.Chart4.Text = "Chart4"
        '
        'Chart5
        '
        Me.Chart5.BackColor = System.Drawing.Color.LightGray
        ChartArea12.Name = "ChartArea1"
        Me.Chart5.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.Chart5.Legends.Add(Legend12)
        Me.Chart5.Location = New System.Drawing.Point(917, 128)
        Me.Chart5.Name = "Chart5"
        Me.Chart5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chart5.Size = New System.Drawing.Size(423, 300)
        Me.Chart5.TabIndex = 21
        Me.Chart5.Text = "Chart5"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Location = New System.Drawing.Point(12, 452)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(182, 51)
        Me.BtnLogout.TabIndex = 22
        Me.BtnLogout.Text = "     LOG OUT"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'FormDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1362, 515)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.Chart5)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.BtnAddChart)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormDashBoard"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents BtnAddChart As Button
    Friend WithEvents Chart4 As DataVisualization.Charting.Chart
    Friend WithEvents Chart5 As DataVisualization.Charting.Chart
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnLogout As Button
End Class
