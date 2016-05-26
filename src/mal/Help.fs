module Help

let message = """
Core Language:

    Booleans:
        mal> true
        true
        mal> false
        false

    Integers:
        mal> 42
        42

    Atoms:
        Atoms begin with a colon:
            mal> :lisprocks
            :lisprocks
        Like all identifiers, they can contain dashes:
            mal> :lisp-rocks
            :lisp-rocks
        and (forward) slashes:
            mal> :lisp/rocks
            :lisp/rocks
        and question marks:
            mal> :lisp?rocks?
            :lisp?rocks?

    Strings:
        mal> "Hello world"
        "Hello world"

    Lists:
        List elements are whitespace-separated; no need for commas:
            mal> [1 2 3]
            [1 2 3]
        Commas however are treated as whitespace, so this is legal:
            mal> [1, 2, 3]
            [1 2 3]

    Conditions:
        If-then-else uses the if keyword:
            mal> (if false 3 4)
            4
        It does not evaluate the required term until necessary.

    Functions:
        Functions are values; they are first-class:
            mal> +
            #<func 1>
        A number of functions come built-in. See below.


    Applications
        Function application has the form (<func> <arg1> <arg2> ... <argN>):
            mal> (+ 1 2)
            3
        For more examples, see the section on functions below.

    Quoting:
        Quoting defers the execution of code:
            mal> '+
            +
            mal> '(+ 1 2)
            (+ 1 2)
        The ' operator is syntactic sugar for the quote function; see the section below.

Built-in Functions:

    Integer Arithmetic:
        Addition:
            mal> (+ 3 4)
            7
        Subtraction:
            mal> (- 3 4)
            -1
        Division:
            mal> (/ 3 4)
            0
        Multiplication:
            mal> (* 3 4)
            12

    Comparison:
        Equality:
            mal> (= 3 4)
            false
            mal> (= "foo" "bar")
            false
        Greater Than:
            mal> (> 3 4)
            false
        Greater Than or Equal To:
            mal> (>= 3 4)
            false
        Less Than:
            mal> (< 3 4)
            true
        Less Than or Equal To:
            mal> (<= 3 4)
            true

        Quoting:

REPL Commands:
    Use ;quit or ;q or ;exit to quit the REPL.
    Use ;help or ;h or ;? to show this message.
    
If this message did not provide the help you needed, feel free to improve it."""
