/**********************************************************************\

 RageLib - Shaders
 Copyright (C) 2009  Arushan/Aru <oneforaru at gmail.com>

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.

\**********************************************************************/

using System.Collections.Generic;
using System.IO;
using RageLib.Common;

namespace RageLib.Shaders.ShaderFX
{
  internal class Variables : IFileAccess
  {
    public List<VariableDefinition> Definitions { get; private set; }

    public Variables()
    {
    }

    public Variables(BinaryReader br)
    {
      Read(br);
    }

    #region Implementation of IFileAccess

    public void Read(BinaryReader br)
    {
      int variableCount = br.ReadByte();
      Definitions = new List<VariableDefinition>(variableCount);
      for (int i = 0; i < variableCount; i++)
      {
        Definitions.Add(new VariableDefinition(br));
      }
    }

    public void Write(BinaryWriter bw)
    {
      throw new System.NotImplementedException();
    }

    #endregion
  }
}