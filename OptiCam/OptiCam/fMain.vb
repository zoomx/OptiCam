Public Class fMain
    Public DrawArea As Bitmap
    Private Sub fMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load


        DrawArea = New Bitmap(PictureBox1.Size.Width, PictureBox1.Size.Height)
        PictureBox1.Image = DrawArea
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim g As Graphics
        DrawArea = New Bitmap(PictureBox1.Size.Width, PictureBox1.Size.Height)
        DrawArea.SetPixel(100, 100, Color.Black)
        g = Graphics.FromImage(DrawArea)
        Dim mySolidColorBrush As SolidBrush = Brushes.Black
        'mySolidColorBrush.Color = Color.Aqua
        Dim mypen As Pen = New Pen(Color.Black)
        Dim mybrush As Brush
        mybrush = Brushes.Black
        g.FillRectangle(mybrush, 100, 100, 10, 10)
        Dim mycolor As Color
        mycolor = Color.FromArgb(10, 10, 10)
        mySolidColorBrush.Color = Color.FromArgb(128, 128, 128)
        mybrush = mySolidColorBrush
        g.FillRectangle(mybrush, 120, 120, 10, 10)
        'mypen.Brush = Brushes.Black
        mypen.Width = 2
        'mycolor=(10,10,10,10)
        'mypen.Color =
        g.DrawLine(mypen, 0, 0, 15, 15)

        PictureBox1.Image = DrawArea
        PictureBox1.Refresh()
        g.Dispose()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim g As Graphics
        PictureBox1.Refresh()
        g = PictureBox1.CreateGraphics
        Dim mypen As Pen = New Pen(Color.Black, 2)
        'mypen.Brush = Brushes.Black
        'mypen.Width = 2

        g.DrawLine(mypen, 0, 0, 15, 15)
        'g.Dispose()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'capture
        'wait for startline
        'get entire line and split in 15
        'draw 15 ppoint
    End Sub
End Class
