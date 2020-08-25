using System;
using System.Collections.Generic;
using System.Text;

namespace Smb.Core.Messages
{
    public class MarshallingAttributes
    {
        /// <summary>
        /// An attribute which indicates the static size of a runtime value. 
        /// </summary>
        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
        // The following suppression is adopted because these fields are only used by reflection, there is no need to define accessors.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments")]
        public sealed class StaticSizeAttribute : Attribute
        {
            // The following suppression is adopted because this field will be used by reflection.
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            internal int size;

            // The following suppression is adopted because this field will be used by reflection.
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            internal StaticSizeMode mode;

            /// <summary>
            /// Constructs a static size attribute by using the given static size.
            /// </summary>
            /// <param name="size">The static size.</param>
            public StaticSizeAttribute(int size)
            {
                this.size = size;
                this.mode = StaticSizeMode.Bytes;
            }

            /// <summary>
            /// Constructs a static size attribute by using given static size and static size mode.
            /// </summary>
            /// <param name="size">The static size.</param>
            /// <param name="mode">The mode for calculating the size.</param>
            public StaticSizeAttribute(int size, StaticSizeMode mode)
            {
                this.size = size;
                this.mode = mode;
            }
        }

        /// <summary>
        /// An attribute which indicates the size of a runtime value. 
        /// </summary>
        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
        // The following suppression is adopted because these fields are only used by reflection, there is no need to define accessors.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments")]
        public sealed class SizeAttribute : Attribute
        {
            // The following suppression is adopted because this field will be used by reflection.
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            internal string expr;

            /// <summary>
            /// Constructs a size attribute by using the given size expression.
            /// </summary>
            /// <param name="expression">The size expression.</param>
            public SizeAttribute(string expression)
            {
                this.expr = expression;
            }
        }

        /// <summary>
        /// An enumeration type which defines the mode for evaluating the static size expression.
        /// </summary>
        public enum StaticSizeMode
        {
            /// <summary>
            /// Indicates to evaluate static size of bytes.
            /// </summary>
            Bytes,

            /// <summary>
            /// Indicates to evaluate static size of elements.
            /// </summary>
            Elements
        }

    }
}
