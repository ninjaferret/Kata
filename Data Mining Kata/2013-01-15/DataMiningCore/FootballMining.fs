module FootballMining
open System
open System.Linq

let inline splitBySomething (chara:Char) (values:string)= values.Split([chara].ToArray(), StringSplitOptions.RemoveEmptyEntries ) 
let inline split(value)= value |> splitBySomething '\n' |> List.ofSeq |> List.map (splitBySomething ' ')
let inline modSubtract(a:decimal,b:decimal)=     Math.Abs(a-b)
let inline subtract(a,b)= (a-b)

let ExtractVariance funtimes (labelElement, firstElement, secondElement) (input:string[])  =
    (input.[labelElement], (funtimes ((Decimal.Parse(input.[firstElement])), (Decimal.Parse(input.[secondElement])))))

let mineData limit identifier operand1 operand2 operation input =
    input |> split |> List.ofSeq |> List.filter (fun arr -> arr.Length >= limit) |> List.map (ExtractVariance operation (identifier, operand1, operand2))

let getIdentifierOfMinimum namesAndValues =
    let (text, _ ) = (List.minBy (fun (_, difference) -> difference) namesAndValues)
    text

let inline GetClubWithLowestGoalDifference( input ) =  input |> mineData 8 1 6 8 modSubtract |> getIdentifierOfMinimum
let inline GetWeatherWithLowestVariance (input) =  input |> mineData 2 0 1 2 subtract |> getIdentifierOfMinimum

