﻿/*
 * Magic Cloud, copyright Aista, Ltd. See the attached LICENSE file for details.
 */

using magic.node;
using magic.node.extensions;
using magic.signals.contracts;
using magic.lambda.openai.utilities;

namespace magic.lambda.openai
{
    /// <summary>
    /// [openai.tokenize] slot for tokenizing the specified input.
    /// </summary>
    [Slot(Name = "openai.tokenize")]
    public class Tokenizer : ISlot
    {
        /// <summary>
        /// Slot implementation.
        /// </summary>
        /// <param name="signaler">Signaler that raised the signal.</param>
        /// <param name="input">Arguments to slot.</param>
        public void Signal(ISignaler signaler, Node input)
        {
            var txt = input.GetEx<string>();
            var list = GPT3Tokenizer.Encode(txt);
            input.Value = list.Count;
        }
    }
}
