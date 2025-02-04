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
    /// ManagedFieldsEntry is a workflow-id, a FieldSet and the group version of the
        /// resource that the fieldset applies to.
    /// </summary>
    public partial class V1ManagedFieldsEntry
    {
        /// <summary>
        /// Initializes a new instance of the V1ManagedFieldsEntry class.
        /// </summary>
        public V1ManagedFieldsEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ManagedFieldsEntry class.
        /// </summary>
        /// <param name="apiVersion">
        /// APIVersion defines the version of this resource that this field set applies to.
        /// The format is &quot;group/version&quot; just like the top-level APIVersion field. It is
        /// necessary to track the version of a field set because it cannot be automatically
        /// converted.
        /// </param>
        /// <param name="fieldsType">
        /// FieldsType is the discriminator for the different fields format and version.
        /// There is currently only one possible value: &quot;FieldsV1&quot;
        /// </param>
        /// <param name="fieldsV1">
        /// FieldsV1 holds the first JSON version format as described in the &quot;FieldsV1&quot;
        /// type.
        /// </param>
        /// <param name="manager">
        /// Manager is an identifier of the workflow managing these fields.
        /// </param>
        /// <param name="operation">
        /// Operation is the type of operation which lead to this ManagedFieldsEntry being
        /// created. The only valid values for this field are &apos;Apply&apos; and &apos;Update&apos;.
        /// </param>
        /// <param name="subresource">
        /// Subresource is the name of the subresource used to update that object, or empty
        /// string if the object was updated through the main resource. The value of this
        /// field is used to distinguish between managers, even if they share the same name.
        /// For example, a status update will be distinct from a regular update using the
        /// same manager name. Note that the APIVersion field is not related to the
        /// Subresource field and it always corresponds to the version of the main resource.
        /// </param>
        /// <param name="time">
        /// Time is timestamp of when these fields were set. It should always be empty if
        /// Operation is &apos;Apply&apos;
        /// </param>
        public V1ManagedFieldsEntry(string apiVersion = null, string fieldsType = null, object fieldsV1 = null, string manager = null, string operation = null, string subresource = null, System.DateTime? time = null)
        {
            ApiVersion = apiVersion;
            FieldsType = fieldsType;
            FieldsV1 = fieldsV1;
            Manager = manager;
            Operation = operation;
            Subresource = subresource;
            Time = time;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIVersion defines the version of this resource that this field set applies to.
        /// The format is &quot;group/version&quot; just like the top-level APIVersion field. It is
        /// necessary to track the version of a field set because it cannot be automatically
        /// converted.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// FieldsType is the discriminator for the different fields format and version.
        /// There is currently only one possible value: &quot;FieldsV1&quot;
        /// </summary>
        [JsonProperty(PropertyName = "fieldsType")]
        public string FieldsType { get; set; }

        /// <summary>
        /// FieldsV1 holds the first JSON version format as described in the &quot;FieldsV1&quot;
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "fieldsV1")]
        public object FieldsV1 { get; set; }

        /// <summary>
        /// Manager is an identifier of the workflow managing these fields.
        /// </summary>
        [JsonProperty(PropertyName = "manager")]
        public string Manager { get; set; }

        /// <summary>
        /// Operation is the type of operation which lead to this ManagedFieldsEntry being
        /// created. The only valid values for this field are &apos;Apply&apos; and &apos;Update&apos;.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Subresource is the name of the subresource used to update that object, or empty
        /// string if the object was updated through the main resource. The value of this
        /// field is used to distinguish between managers, even if they share the same name.
        /// For example, a status update will be distinct from a regular update using the
        /// same manager name. Note that the APIVersion field is not related to the
        /// Subresource field and it always corresponds to the version of the main resource.
        /// </summary>
        [JsonProperty(PropertyName = "subresource")]
        public string Subresource { get; set; }

        /// <summary>
        /// Time is timestamp of when these fields were set. It should always be empty if
        /// Operation is &apos;Apply&apos;
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

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
