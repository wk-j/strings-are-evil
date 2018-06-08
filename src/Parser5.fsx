#load "ValueHolder.fsx"

open System.Text
open System
open ValueHolder
open System.Collections.Generic

open System.IO

let sb = StringBuilder()
let parseSection (start, ends, line: string) =
    sb.Clear() |> ignore
    for i in start .. (ends - 1) do
        sb.Append(line.[i]) |> ignore
    sb.ToString()

let findCommasInLine (line: string) =
    let list = new List<int>()
    for i in 0 .. (line.Length - 1) do
        if line.[i] = ',' then
            list.Add i
    list

let viaStreamReader(file: string) =
    use reader = File.OpenText file
    while reader.EndOfStream |> not do
        let line = reader.ReadLine()
        if line.StartsWith "MNO" then
            let mm = findCommasInLine line
            ValueHolder.FromFields(
                parseSection (mm.[0] + 1, mm.[1], line) |> Int32.Parse,
                parseSection (mm.[1] + 1, mm.[2], line) |> Int32.Parse,
                parseSection (mm.[2] + 1, mm.[3], line) |> Int32.Parse,
                parseSection (mm.[3] + 1, mm.[4], line) |> Int32.Parse,
                parseSection (mm.[4] + 1, mm.[5], line) |> Double.Parse
            ) |> ignore


#time
viaStreamReader "release/example-input.txt"
#time