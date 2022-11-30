Imports System.Runtime.InteropServices

Public Class frmlogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
    End Sub
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblhora.Text = TimeOfDay

    End Sub
    Private Sub OK_Paint(sender As Object, e As PaintEventArgs) Handles OK.Paint
        Dim buttonpath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = OK.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonpath.AddEllipse(myRectangle)
        OK.Region = New Region(buttonpath)


    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim userModel As New vusuario()
        Dim validLogin = userModel.Loginn(txtlogin.Text, txtpassword.Text)
        If validLogin = True Then
            Dim frm As New INICIO()
            frm.Show()
            Me.Hide()
        Else
            MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "Accesos denegado al sistema")
            txtpassword.Clear()
            txtpassword.Focus()

        End If

        'Diferente login Men 
        'Try
        'Dim dts As New vusuario
        'Dim func As New fusuario
        '
        'dts.glogin = txtlogin.Text
        'dts.gpassword = txtpassword.Text


        'If func.validar_usuario(dts) = True Then
        'INICIO.Show()
        'Me.Hide()
        'Else
        'MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "Accesos denegado al sistema")
        'txtpassword.Clear()
        'End If


        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub



    Private Sub frmlogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtlogin.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cerrar_Click_1(sender As Object, e As EventArgs) Handles Cerrar.Click
        Application.Exit()

    End Sub

    Private Sub Minimizar2_Click(sender As Object, e As EventArgs) Handles Minimizar2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapure()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapure()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub frmlogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapure()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


End Class
