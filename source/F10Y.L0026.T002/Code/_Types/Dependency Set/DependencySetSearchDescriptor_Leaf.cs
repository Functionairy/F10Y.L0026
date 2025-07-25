using System;

using F10Y.T0004;


namespace F10Y.L0026.T002
{
    /// <summary>
    /// Describes a search for dependencies sets that are a "leaf" within a certain context.
    /// </summary>
    /// <remarks>
    /// A dependency set is a "leaf" when it is not allowed to depend on any other sets within a certain context.
    /// For example, a leaf within the "D8S.S0000" context would not be allowed to depend on any other D8S.S0000 projects.
    /// However, it can depend on projects from any context outside of D8S.S0000.
    /// <para>
    /// The concept of a "leaf" dependency set is useful in project dependency management.
    /// A leaf project allows its mission to be declared upfront, at creation.
    /// Then, whenever you want to either add a dependency, or include the project as a dependency, you know whether that dependency will break both existing AND future dependency relationships for the project.
    /// I.e., declaring a project to be a dependency leaf allows you the certainty as to whether that dependency relationship fits the project's declared dependency strategy.
    /// </para>
    /// This leaf type can be seen as the complement to the <see cref="DependencySetSearchDescriptor_Constrained"/> type.
    /// In this leaf, no dependencies from the given context are allowed.
    /// For the constrained type, only dependencies from the given context are allowed.
    /// </remarks>
    [DataTypeMarker]
    public class DependencySetSearchDescriptor_Leaf : IDependencySetSearchDescriptor
    {
        public string Context_Name { get; set; }
    }
}
