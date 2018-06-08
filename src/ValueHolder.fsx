open System

type ValueHolder = {
    ElementId: int
    VehicleId: int
    Term: int
    Mileage: int
    Value: float
} with
    static member FromLine(line: string) =
        let parts = line.Split ','
        { ElementId = Int32.Parse <| parts.[1]
          VehicleId = Int32.Parse <| parts.[2]
          Term = Int32.Parse <| parts.[3]
          Mileage = Int32.Parse <| parts.[4]
          Value = Double.Parse <| parts.[5] }
    static member FromArray(parts: string array) =
        { ElementId = Int32.Parse <| parts.[1]
          VehicleId = Int32.Parse <| parts.[2]
          Term = Int32.Parse <| parts.[3]
          Mileage = Int32.Parse <| parts.[4]
          Value = Double.Parse <| parts.[5] }
    static member FromFields(elementId, vehicleId, term, mileage, value) =
         { ElementId = elementId
           VehicleId = vehicleId
           Term = term
           Mileage = mileage
           Value = value }

    override this.ToString() =
         this.ElementId.ToString() + ","
            + this.VehicleId.ToString() + ","
            + this.Term.ToString() + ","
            + this.Mileage.ToString() + ","
            + this.Value.ToString();