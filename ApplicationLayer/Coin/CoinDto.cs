﻿// Cypher (c) by Tangram LLC
// 
// Cypher is licensed under a
// Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
// 
// You should have received a copy of the license along with this
// work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>.

using System;
namespace TangramCypher.ApplicationLayer.Coin
{
    public class CoinDto
    {
        public EnvelopeDto Envelope { get; set; }
        public string Hash { get; set; }
        public string Hint { get; set; }
        public string Keeper { get; set; }
        public string Principle { get; set; }
        public string Stamp { get; set; }
        public int Version { get; set; }
    }
}
