Imports Newtonsoft.Json

Public Class ComponentListPreset
    <JsonProperty("presetName")>
    Public Property presetName

    <JsonProperty("components")>
    Public Property components As List(Of Component)

    'Constructors
    Public Sub New()
    End Sub


    Public Sub New(name As String, comps As List(Of Component))
        presetName = name
        components = comps
    End Sub
End Class

Public Class Component
    <JsonProperty("code")>
    Public code As String

    <JsonProperty("quantity")>
    Public quantity As Integer

    <JsonProperty("markUp")>
    Public markUp As Double

    'Constructors
    Public Sub New()
    End Sub

    Public Sub New(c As String, q As Integer, m As Double)
        code = c
        quantity = q
        markUp = m
    End Sub
End Class