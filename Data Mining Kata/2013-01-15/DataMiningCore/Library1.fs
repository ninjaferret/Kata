namespace DataMiningCore

open System
open System.Linq

type Class1() = 
    let splitBySomething (chara:Char) (values:string)=
        values.Split([chara].ToArray(), StringSplitOptions.RemoveEmptyEntries ) 
    member this.split(value)=
        value |> splitBySomething '\n' |> List.ofSeq |> List.map (splitBySomething ' ')
    member this.ExtractVariance(input:string[], firstElement:int, secondElement:int) =
        (input.[0], Decimal.Parse(input.[firstElement]) - Decimal.Parse(input.[secondElement]))
