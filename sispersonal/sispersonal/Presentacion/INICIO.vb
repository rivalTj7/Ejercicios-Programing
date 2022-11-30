Imports System.Runtime.InteropServices

Public Class INICIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWind As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub hideSubmenu()
        panelsub1.Visible = False
        Panel3.Visible = False

    End Sub
    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False

        End If
    End Sub
    Private Sub INICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = ActiveUser.nombre + ", " + ActiveUser.apellido
        lblposicion.Text = ActiveUser.position
        lblemail.Text = ActiveUser.email
        hideSubmenu()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        OpenChildForm(New frmcategoria)


        hideSubmenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmsalidas.Show()
        Me.Hide()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Application.Exit()
    End Sub

    Private Sub Minimizar2_Click(sender As Object, e As EventArgs) Handles Minimizar2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximizar_Click(sender As Object, e As EventArgs) Handles maximizar.Click
        maximizar.Visible = False
        minimizar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        minimizar.Visible = False
        maximizar.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub barraTitulos_MouseMove(sender As Object, e As MouseEventArgs) Handles barraTitulos.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &HF112&, &HF012&, 0)

    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If MenuVertical.Width <= 60 Then
            tmOcultarMenu.Enabled = False
        Else
            Me.MenuVertical.Width = MenuVertical.Width - 20

        End If
    End Sub

    Private Sub tmtMostarMenu_Tick(sender As Object, e As EventArgs) Handles tmtMostarMenu.Tick
        If MenuVertical.Width >= 250 Then
            tmtMostarMenu.Enabled = False
        Else
            Me.MenuVertical.Width = MenuVertical.Width + 20

        End If
    End Sub

    Private Sub btnindex_Click(sender As Object, e As EventArgs) Handles btnindex.Click

        If MenuVertical.Width = 250 Then
            tmOcultarMenu.Enabled = True
        ElseIf MenuVertical.Width <= 60 Then
            tmtMostarMenu.Enabled = True
        End If
    End Sub
    Private currentForm As Form = Nothing
    Private Sub OpenChildForm(ChildForm As Object)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = ChildForm
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        panelContenedor.Controls.Add(ChildForm)
        panelContenedor.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btningresos_Click(sender As Object, e As EventArgs) Handles btningresos.Click
        showSubmenu(panelsub1)

    End Sub

    Private Sub btnreportes_Click(sender As Object, e As EventArgs) Handles btnreportes.Click
        showSubmenu(Panel3)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        hideSubmenu()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click


        hideSubmenu()

    End Sub

    Private Sub btnsalidas_Click(sender As Object, e As EventArgs) Handles btnsalidas.Click
        OpenChildForm(New frmsalidas)
        hideSubmenu()
    End Sub

    Private Sub btnRproducto_Click(sender As Object, e As EventArgs) Handles btnRproducto.Click

        hideSubmenu()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        hideSubmenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hideSubmenu()
    End Sub

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Dim si As String
        si = InputBox("Introduce contraseña para continuar", "Sistema")
        If si = "Administrador" Then
            OpenChildForm(New frmbackup)
        Else
            MsgBox("Error")
        End If


        hideSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        frmlogin.Show()

    End Sub

    Private Sub panelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles panelContenedor.Paint

    End Sub
End Class