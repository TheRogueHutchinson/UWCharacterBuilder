Imports Microsoft.VisualBasic

Public Class Skill
    Public Property Purchases As System.Windows.Forms.NumericUpDown()
        Get
            Return p_purchases
        End Get
        Set(value As System.Windows.Forms.NumericUpDown())
            p_purchases = value
        End Set
    End Property
    Private p_purchases As System.Windows.Forms.NumericUpDown()

    Public Property Label As System.Windows.Forms.Label()
        Get
            Return p_label
        End Get
        Set(value As System.Windows.Forms.Label())
            p_label = value
        End Set
    End Property
    Private p_label As System.Windows.Forms.Label()

    Public Property Cost As System.Windows.Forms.Label()
        Get
            Return p_cost
        End Get
        Set(value As System.Windows.Forms.Label())
            p_cost = value
        End Set
    End Property
    Private p_cost As System.Windows.Forms.Label()
End Class
