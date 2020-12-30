//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from f:\Dev\Antlr\BS_Reach.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="BS_ReachParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
//[System.CLSCompliant(false)]
public interface IBS_ReachListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.hsc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHsc([NotNull] BS_ReachParser.HscContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.hsc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHsc([NotNull] BS_ReachParser.HscContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.globalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalDeclaration([NotNull] BS_ReachParser.GlobalDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.globalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalDeclaration([NotNull] BS_ReachParser.GlobalDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.scriptDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScriptDeclaration([NotNull] BS_ReachParser.ScriptDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.scriptDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScriptDeclaration([NotNull] BS_ReachParser.ScriptDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.scriptParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScriptParameters([NotNull] BS_ReachParser.ScriptParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.scriptParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScriptParameters([NotNull] BS_ReachParser.ScriptParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCond([NotNull] BS_ReachParser.CondContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCond([NotNull] BS_ReachParser.CondContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.branch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBranch([NotNull] BS_ReachParser.BranchContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.branch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBranch([NotNull] BS_ReachParser.BranchContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCall([NotNull] BS_ReachParser.CallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCall([NotNull] BS_ReachParser.CallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.condGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondGroup([NotNull] BS_ReachParser.CondGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.condGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondGroup([NotNull] BS_ReachParser.CondGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] BS_ReachParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] BS_ReachParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.scriptID"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScriptID([NotNull] BS_ReachParser.ScriptIDContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.scriptID"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScriptID([NotNull] BS_ReachParser.ScriptIDContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.callID"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallID([NotNull] BS_ReachParser.CallIDContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.callID"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallID([NotNull] BS_ReachParser.CallIDContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] BS_ReachParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] BS_ReachParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BS_ReachParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] BS_ReachParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BS_ReachParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] BS_ReachParser.LiteralContext context);
}