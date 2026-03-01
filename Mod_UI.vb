Module Mod_UI

    Public Class Design

        Public Shared ScrollBars As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        Public Shared Sub SetWindowsSize()

            If Not Settings.AppSize = New Size(0, 0) Then
                MainContainer.Size = Settings.AppSize
            Else
                Dim screenWidth As Integer = Math.Round(Screen.PrimaryScreen.Bounds.Width \ 2) + (Screen.PrimaryScreen.Bounds.Width * 0.12)
                Dim screenHeight As Integer = Math.Round(Screen.PrimaryScreen.Bounds.Height \ 2) + (Screen.PrimaryScreen.Bounds.Height * 0.12)
                MainContainer.Size = New Size(screenWidth, screenHeight)
            End If


        End Sub

        Public Shared Sub SetTheme()

            AboutStrongchest.ApplyTheme()

        End Sub
        Public Shared Sub CreateResizer()

            Dim resizeTool As New Guna.UI.WinForms.GunaResizeControl With {
                .MaximumSize = New Size(20, 20),
                .MinimumSize = New Size(20, 20),
                .Location = New Point(MainContainer.pnlContainer.Width - 20, MainContainer.pnlContainer.Height - 20),
                .Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom),
                .TargetControl = MainContainer,
                .ForeColor = Color.Gainsboro
        }

            MainContainer.pnlContainer.Controls.Add(resizeTool)

            resizeTool.Show()
            resizeTool.BringToFront()


        End Sub

        Public Shared Sub SwitchForm(Target As Form)
            MainContainer.pnlContainer.Controls.Clear()
            Target.TopLevel = False
            Target.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Left)
            Target.Size = New Size(MainContainer.Size.Width, MainContainer.Size.Height - 25)
            MainContainer.pnlContainer.Controls.Add(Target)

            Target.Visible = True
            Target.Show()
            Target.BringToFront()


        End Sub

        Public Shared Sub BackgroundSwitch(Target As Form)

            Target.TopLevel = False
            Target.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Left)
            Target.Size = New Size(MainContainer.Size.Width, MainContainer.Size.Height - 25)
            MainContainer.pnlContainer.Controls.Add(Target)
            Target.Visible = False
            Target.SendToBack()
            Target.Show()

        End Sub

        Public Shared Sub ShowBackground(Target As Form)

            Target.BringToFront()
            Target.Visible = True
            Home.CreateResizerHome()

        End Sub

        Public Shared Sub PanelSwitch(Target As Form)

            'Show menu
            Target.TopLevel = False
            Dim X = (MainContainer.pnlContainer.Size.Width - Target.Width) / 2
            Dim Y = (MainContainer.pnlContainer.Size.Height - Target.Height) / 2
            Target.Location = New Point(X, Y)
            MainContainer.pnlContainer.Controls.Add(Target)
            Target.Show()
            Target.Anchor = AnchorStyles.None
            Target.BringToFront()


        End Sub


    End Class








End Module
