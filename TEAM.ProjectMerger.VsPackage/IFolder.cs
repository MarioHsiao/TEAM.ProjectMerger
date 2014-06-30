﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEAM.TEAM_ProjectMerger
{
   public interface IFolder
   {
      Task<IFolder> AddFolder(string directoryName);
      void AddFromFileCopy(string filePath);
   }
}
