Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim COEFSTEWARD As Double
        Dim COEFDECK As Double
        Dim LENGTHWL As Double
        Dim BREADTH As Double
        Dim DRAUGHT As Double
        Dim Coefed As Double
        Dim cadet As Double
        Dim bhpengine As Double
        Dim totalcrewnum As Short
        Dim cubicnumber As Double
        Dim engine As Double

        If CSD.Text = "" Then
            MessageBox.Show("Please Insert coeffisient steward departement")
            Return
        Else
            COEFSTEWARD = Val(CSD.Text)
        End If

        If CDDT.Text = "" Then
            MessageBox.Show("Please Insert coefficient deck departement")
            Return
        Else
            COEFDECK = Val(CDDT.Text)
        End If

        If LWL.Text = "" Then
            MessageBox.Show("Please Insert Length of Water Line")
            Return
        Else
            LENGTHWL = Val(LWL.Text)
        End If

        If BREADTHTT.Text = "" Then
            MessageBox.Show("Please Insert Breadth")
            Return
        Else
            BREADTH = Val(BREADTHTT.Text)
        End If

        If DT.Text = "" Then
            MessageBox.Show("Please Insert Draught")
            Return
        Else
            DRAUGHT = Val(DT.Text)
        End If

        If cep.Text = "" Then
            MessageBox.Show("Please Insert Coefficient Engine Departement")
            Return
        Else
            Coefed = Val(cep.Text)
        End If

        If CDET.Text = "" Then
            MessageBox.Show("Please Insert Cadet")
            Return
        Else
            cadet = Val(CDET.Text)
        End If

        If BHPME.Text = "" Then
            MessageBox.Show("Please Insert Power of Main Engine")
            Return
        Else
            bhpengine = Val(BHPME.Text)
        End If

        cubicnumber = Val((LENGTHWL * BREADTH * DRAUGHT) / 1000)
        engine = Val(bhpengine / 1000)
        totalcrewnum = Val(COEFSTEWARD * ((COEFDECK * ((cubicnumber / 1000) ^ 0.16667)) + (Coefed * ((engine) ^ 0.2)) + (cadet)))
        TOTALCREW.Text = totalcrewnum
        MessageBox.Show("TOTAL CREW OF SHIP MEMBERS ARE " + CStr(totalcrewnum) + " PERSON")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Do you want to reset the datas?" + MessageBoxButtons.YesNo)
        MessageBox.Show("are you sure?")
        CSD.Text = ""
        CDDT.Text = ""
        LWL.Text = ""
        BREADTHTT.Text = ""
        DT.Text = ""
        cep.Text = ""
        CDET.Text = ""
        BHPME.Text = ""
        TOTALCREW.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim check As Boolean

        check = CheckBox1.Checked

        If check = True Then
            MessageBox.Show("Khairan Tampan")

        End If
    End Sub
End Class
