













//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Year : ReqlExpr  {

    
    
    
/// <summary>
/// <para>Return the year of a time object.</para>
/// </summary>
/// <example><para>Example: Retrieve all the users born in 1986.</para>
/// <code>r.table("users").filter(function(user) {
///     return user("birthdate").year().eq(1986)
/// }).run(conn, callback)
/// </code></example>
        public Year (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the year of a time object.</para>
/// </summary>
/// <example><para>Example: Retrieve all the users born in 1986.</para>
/// <code>r.table("users").filter(function(user) {
///     return user("birthdate").year().eq(1986)
/// }).run(conn, callback)
/// </code></example>
        public Year (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the year of a time object.</para>
/// </summary>
/// <example><para>Example: Retrieve all the users born in 1986.</para>
/// <code>r.table("users").filter(function(user) {
///     return user("birthdate").year().eq(1986)
/// }).run(conn, callback)
/// </code></example>
        public Year (Arguments args, OptArgs optargs)
             : this(TermType.YEAR, args, optargs) {
        }

    protected Year (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
