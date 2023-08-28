Public Class Machine
    Public Deliverables As String
    Public MachineFunction As String
    Public Quantity As String

    Public Sub New(deliver, machFunction, quant)
        Deliverables = deliver
        MachineFunction = machFunction
        Quantity = quant
    End Sub
End Class
