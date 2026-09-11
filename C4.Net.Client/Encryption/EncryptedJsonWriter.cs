using Newtonsoft.Json;
using C4.Net.Client.IO.Json;
using System.IO;

namespace C4.Net.Client.Encryption
{
    /// <summary>
    /// Serializes encrypted workspace instances to JSON.
    /// </summary>
    public class EncryptedJsonWriter
    {

        /// <summary>
        /// Controls whether generated JSON should be indented for readability.
        /// </summary>
        public bool IndentOutput { get; set; }

        /// <summary>
        /// Creates a writer for encrypted workspace JSON.
        /// </summary>
        /// <param name="indentOutput">Whether generated JSON should be indented.</param>
        public EncryptedJsonWriter(bool indentOutput)
        {
            this.IndentOutput = indentOutput;
        }

        /// <summary>
        /// Writes an encrypted workspace as JSON.
        /// </summary>
        /// <param name="workspace">The encrypted workspace to serialize.</param>
        /// <param name="writer">The writer that receives the JSON payload.</param>
        public void Write(EncryptedWorkspace workspace, StringWriter writer)
        {
            string json = JsonConvert.SerializeObject(workspace,
                IndentOutput == true ? Formatting.Indented : Formatting.None,
                new Newtonsoft.Json.Converters.StringEnumConverter(),
                new PaperSizeJsonConverter());

            writer.WriteLine(json);
        }


    }
}
