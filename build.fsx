#r @"packages\FAKE\tools\FakeLib.dll"

open Fake

let buildDir = "output"

let clean() =
    CleanDir buildDir

let compileSrcSln () =
    !! "src/*.sln"
    |> MSBuildRelease buildDir "Build"
    |> Log "Compile-Output: "

Target "clean" clean
Target "compile" compileSrcSln
Target "rebuild" DoNothing

"clean" ==> "rebuild"
"clean" ?=> "compile"
"compile" ==> "rebuild"

RunTargetOrDefault "rebuild"
