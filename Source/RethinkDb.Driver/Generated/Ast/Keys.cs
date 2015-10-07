













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

    public class Keys : ReqlExpr  {

    
    
    
/// <summary>
/// <para>Return an array containing all of the object's keys.</para>
/// </summary>
/// <example><para>Example: Get all the keys of a row.</para>
/// <code>r.table('marvel').get('ironman').keys().run(conn, callback)
/// </code></example>
        public Keys (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return an array containing all of the object's keys.</para>
/// </summary>
/// <example><para>Example: Get all the keys of a row.</para>
/// <code>r.table('marvel').get('ironman').keys().run(conn, callback)
/// </code></example>
        public Keys (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return an array containing all of the object's keys.</para>
/// </summary>
/// <example><para>Example: Get all the keys of a row.</para>
/// <code>r.table('marvel').get('ironman').keys().run(conn, callback)
/// </code></example>
        public Keys (Arguments args, OptArgs optargs)
             : this(TermType.KEYS, args, optargs) {
        }

    protected Keys (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
