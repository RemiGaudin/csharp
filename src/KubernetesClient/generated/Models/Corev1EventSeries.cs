// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// EventSeries contain information on series of events, i.e. thing that was/is
        /// happening continuously for some time.
    /// </summary>
    public partial class Corev1EventSeries
    {
        /// <summary>
        /// Initializes a new instance of the Corev1EventSeries class.
        /// </summary>
        public Corev1EventSeries()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1EventSeries class.
        /// </summary>
        /// <param name="count">
        /// Number of occurrences in this series up to the last heartbeat time
        /// </param>
        /// <param name="lastObservedTime">
        /// Time of the last occurrence observed
        /// </param>
        public Corev1EventSeries(int? count = null, System.DateTime? lastObservedTime = null)
        {
            Count = count;
            LastObservedTime = lastObservedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Number of occurrences in this series up to the last heartbeat time
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Time of the last occurrence observed
        /// </summary>
        [JsonProperty(PropertyName = "lastObservedTime")]
        public System.DateTime? LastObservedTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
