Imports Microsoft.VisualBasic

Public Class Costs

    Public Class SkillCost
        Public Property cost As Integer
            Get
                Return _cost
            End Get
            Set(value As Integer)
                value = _cost
            End Set
        End Property
        Private _cost As Integer

        Public Property name As String
            Get
                Return _name
            End Get
            Set(value As String)
                value = _name
            End Set
        End Property
        Private _name As String
    End Class

    Dim MercenaryClassCosts As New Dictionary(Of String, Integer)

    MercenaryClassCosts.Add("Alchemy", 80)



End Class
