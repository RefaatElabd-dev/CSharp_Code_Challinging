
 * Methods and types are the only constructs that can introduce type parameters.
Properties, indexers, events, fields, constructors, operators, and so on cannot
declare type parameters, although they can partake in any type parameters already
declared by their enclosing type.


 * Types are [classes, structs, interfaces, delegates]



 constrains
 By default, you can substitute a type parameter with any type whatsoever.
 Constraints can be applied to a type parameter to require more specific type arguments.
	These are the possible constraints:
	where T : base-class // Base-class constraint
	where T : interface // Interface constraint
	where T : class // Reference-type constraint
	where T : class? // (See "Nullable reference types")
	where T : struct // Value-type constraint (excludes Nullable types)
	where T : unmanaged // Unmanaged constraint
	where T : new() // Parameterless constructor constraint
	where U : T // Naked type constraint
	where T : notnull // Non-nullable value type, or (fro





The unmanaged constraint (introduced in C# 7.3) is a stronger version of a struct
constraint: T must be a simple value type or a struct that is (recursively) free of any
reference types.

