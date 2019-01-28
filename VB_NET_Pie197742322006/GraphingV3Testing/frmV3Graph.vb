Imports Graphing.V3
'Feel free to use this as you wish it is free. With this said
'I hold no responsiblity for any damage mentally or physically, 
'in which you or your computer may experience. It is free from 
'defect as far as I can tell. I didn't comment as much as I wished
'So if you have any questions feel free to email me. I can be found
'on GotDotNet.com user besmith2. Peace out......Bruce Smith


'I added a seperate method to return a image with a key in it.


Public Class frmV3Graph
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pie"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Bar Vert Top"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Line Horizontal"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(112, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Bar Horiz Left"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Bar Vert Bottom"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(112, 352)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Bar Horiz Right"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(216, 352)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Line Vertical"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(314, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'frmV3Graph
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 445)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmV3Graph"
        Me.Text = "frmV3Graph"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim lWidth As Integer = 300, lHeight As Integer = 200

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oV2Pie As New Graphing.V3.Pie.PieChart()
        Dim renderer As New Render

        With oV2Pie
            'Specify the exact size
            .KeyTitle = "Pie"
            .KeyTitleFontStyle = FontStyle.Bold
            .ImageSize = New Size(lWidth, lHeight)
            'Or Auto size
            .AutoSize = False
            .Diameter = 150
            .Thickness = 5
            'Background color for the chart
            .Color = Color.White
            'Adds a border around the pie.
            .GraphBorder = True
            'Adding pieces is fairly straight forward.
            .PieSliceCollection.Add(New Graphing.V3.Pie.PieSlice(25.0, Color.FromArgb(204, 0, 0), "Ford"))
            .PieSliceCollection.Add(New Graphing.V3.Pie.PieSlice(43.0, Color.FromArgb(204, 0, 255), "Chevy"))
            .PieSliceCollection.Add(New Graphing.V3.Pie.PieSlice(22.0, Color.FromArgb(204, 153, 255), "This is a really long key name."))
            .PieSliceCollection.Add(New Graphing.V3.Pie.PieSlice(34.0, Color.FromArgb(51, 0, 153), "VW"))
            .PieSliceCollection.Add(New Graphing.V3.Pie.PieSlice(11.0, Color.FromArgb(51, 102, 153), "Suzuki"))
        End With
        PictureBox1.Image = renderer.DrawChart(oV2Pie)
        PictureBox2.Image = renderer.DrawKey(oV2Pie)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oV2Bar As New Graphing.V3.Bar.BarChart()
        Dim renderer As New Render

        With oV2Bar
            'Barcharts have an alignment
            .KeyTitle = "Bar Vert Top"

            .Alignment = Base.b_BarTypes.VerticalTop
            'Background color
            .Color = Color.White
            'Really does nothing in a barchart.
            .GraphBorder = False
            'Will autosize the chart
            .AutoSize = False
            'Specify the size.
            .ImageSize = New Size(lWidth, lHeight)

            'Adding pieces is fairly straight forward.
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(130.0, Color.Blue, "Key1"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(10.0, Color.Black, "Key2"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(87.0, Color.BlanchedAlmond, "Key3"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(20.0, Color.Red, "Key4"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(93.0, Color.Purple, "Key5"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(500.0, Color.Green, "Key6"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(230.0, Color.Yellow, "Key7"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(90.0, Color.Pink, "Key8"))
        End With
        PictureBox1.Image = renderer.DrawChart(oV2Bar)
        PictureBox2.Image = renderer.DrawKey(oV2Bar)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oV2Bar As New Graphing.V3.Bar.BarChart()
        Dim renderer As New Render

        With oV2Bar
            .KeyTitle = "Bar Horiz Left"
            .Alignment = Base.b_BarTypes.HorizontalLeft
            .Color = Color.White
            .GraphBorder = True
            .AutoSize = False
            .ImageSize = New Size(lWidth, lHeight)
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(30.0, Color.FromArgb(204, 0, 0), "Key1"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(10.0, Color.FromArgb(204, 0, 255), "Key2"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(180.0, Color.FromArgb(204, 153, 255), "Key3"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(20.0, Color.FromArgb(51, 0, 153), "Key4"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(93.0, Color.FromArgb(51, 102, 153), "Key5"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(89.0, Color.FromArgb(102, 153, 255), "Key6"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(30.0, Color.FromArgb(51, 102, 0), "Key7"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(90.0, Color.FromArgb(51, 153, 0), "Key8"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(20.0, Color.FromArgb(51, 0, 153), "Key9"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(93.0, Color.FromArgb(51, 102, 153), "Key10"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(2.0, Color.FromArgb(102, 153, 255), "Key11"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(30.0, Color.FromArgb(51, 102, 0), "Key12"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(90.0, Color.FromArgb(51, 153, 0), "Key13"))
        End With
        PictureBox1.Image = renderer.DrawChart(oV2Bar)
        PictureBox2.Image = renderer.DrawKey(oV2Bar)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim oV2Bar As New Graphing.V3.Bar.BarChart()
        Dim renderer As New Render

        With oV2Bar
            .KeyTitle = "Bar Vert Bottom"
            .Alignment = Base.b_BarTypes.VerticalBottom
            .Color = Color.White

            .GraphBorder = True
            .AutoSize = False
            .ImageSize = New Size(lWidth, lHeight)
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(30.0, Color.FromArgb(204, 0, 0), "Key1"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(10.0, Color.FromArgb(204, 0, 255), "Key2"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(180.0, Color.FromArgb(204, 153, 255), "Key3"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(20.0, Color.FromArgb(51, 0, 153), "Key4"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(93.0, Color.FromArgb(51, 102, 153), "Key5"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(89.0, Color.FromArgb(102, 153, 255), "Key6"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(30.0, Color.FromArgb(51, 102, 0), "Key7"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(90.0, Color.FromArgb(51, 153, 0), "Key8"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(20.0, Color.FromArgb(51, 0, 153), "Key9"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(93.0, Color.FromArgb(51, 102, 153), "Key10"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(2.0, Color.FromArgb(102, 153, 255), "Key11"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(30.0, Color.FromArgb(51, 102, 0), "Key12"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(90.0, Color.FromArgb(51, 153, 0), "Key13"))
        End With
        PictureBox1.Image = renderer.DrawChart(oV2Bar)
        PictureBox2.Image = renderer.DrawKey(oV2Bar)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim oV2Bar As New Graphing.V3.Bar.BarChart()
        Dim renderer As New Render

        With oV2Bar
            .KeyTitle = "Bar Horiz Right"
            .Alignment = Base.b_BarTypes.HorizontalRight
            .Color = Color.White
            .GraphBorder = True
            .AutoSize = False
            .ImageSize = New Size(lWidth, lHeight)
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(130.0, Color.Blue, "Key2"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(10.0, Color.Black, "Key2"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(87.0, Color.BlanchedAlmond, "Key3"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(20.0, Color.Red, "Key4"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(93.0, Color.Purple, "Key5"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(500.0, Color.Green, "Key6"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(230.0, Color.Yellow, "Key7"))
            .BarSliceCollection.Add(New Graphing.V3.Bar.BarSlice(90.0, Color.Pink, "Key8"))
        End With
        PictureBox1.Image = renderer.DrawChart(oV2Bar)
        PictureBox2.Image = renderer.DrawKey(oV2Bar)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oV2Line As New Graphing.V3.Line.LineChart()
        Dim renderer As New Render

        With oV2Line
            .KeyTitle = "Line Horiz"
            .Alignment = Base.b_LineTypes.Horizontal
            .Color = Color.White
            .GraphBorder = True
            .AutoSize = False
            .ImageSize = New Size(lWidth, lHeight)
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(130.0, Color.Blue, "Key1"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(10.0, Color.Black, "Key2"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(87.0, Color.BlanchedAlmond, "Key3"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(20.0, Color.Red, "Key4"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(93.0, Color.Purple, "Key5"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(500.0, Color.Green, "Key6"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(230.0, Color.Yellow, "Key7"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(90.0, Color.Pink, "Key8"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(93.0, Color.Azure, "Key9"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(500.0, Color.DarkCyan, "Key10"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(230.0, Color.DarkKhaki, "Key12"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(90.0, Color.Bisque, "Key13"))
        End With
        PictureBox1.Image = renderer.DrawChart(oV2Line)
        PictureBox2.Image = renderer.DrawKey(oV2Line)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim oV2Line As New Graphing.V3.Line.LineChart()
        Dim renderer As New Render


        With oV2Line
            .KeyTitle = "Line Vert"
            .Alignment = Base.b_LineTypes.Vertical
            .Color = Color.DarkSlateGray
            .LineColor = Color.White
            'Actually does nothing in line charts
            .GraphBorder = True
            .AutoSize = False
            .ImageSize = New Size(lWidth, lHeight)
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(130.0, Color.Blue, "Key1"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(10.0, Color.Black, "Key2"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(87.0, Color.BlanchedAlmond, "Key3"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(20.0, Color.Red, "Key4"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(93.0, Color.Purple, "Key5"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(500.0, Color.Green, "Key6"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(230.0, Color.Yellow, "Key7"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(90.0, Color.Pink, "Key8"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(93.0, Color.Azure, "Key9"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(500.0, Color.DarkCyan, "Key10"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(230.0, Color.DarkKhaki, "Key11"))
            .LinePlotCollection.Add(New Graphing.V3.Line.LineSlice(90.0, Color.Bisque, "Key12"))
        End With
        PictureBox1.Image = renderer.DrawChart(oV2Line)
        PictureBox2.Image = renderer.DrawKey(oV2Line)

    End Sub



End Class
