using System;

using F10Y.T0004;


namespace F10Y.L0026.T001
{
    /// <summary>
    /// Describes the dependencies of an instances set as a "leaf" within a certain context.
    /// <para>
    /// Note: consider whether to use <see cref="DependencyDescriptor_Leaf"/> as one of the dependencies in the set, rather than <em>the</em> dependency set.
    /// </para>
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
    /// This leaf type can be seen as the complement to the <see cref="DependencySetDescriptor_Constrained"/> type.
    /// In this leaf, no dependencies from the given context are allowed.
    /// For the constrained type, only dependencies from the given context are allowed.
    /// </remarks>
    [DataTypeMarker]
    public class DependencySetDescriptor_Leaf : IDependencySetDescriptor,
        IEquatable<DependencySetDescriptor_Leaf>
    {
        public string Context_Name { get; set; }


        public override bool Equals(object obj)
        {
            var output = obj is DependencySetDescriptor_Leaf applicabilityDescriptor
                && this.Equals(applicabilityDescriptor);

            return output;
        }

        public bool Equals(DependencySetDescriptor_Leaf other)
        {
            var output = true
                && this.Context_Name == other.Context_Name
                ;

            return output;
        }

        public override int GetHashCode()
        {
            var output = Instances.HashCodeOperator.Get_HashCode(this.Context_Name);
            return output;
        }

        public override string ToString()
        {
            var output = Instances.DependencySetDescriptorOperator.To_String(this);
            return output;
        }
    }
}
