﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.PresenceInfo;

namespace DAL
{
    public class ListOfAttendance
    {
        public IReadAFileRepository ReadAFileRepository{get; set;}

        public ListOfAttendance(IReadAFileRepository readAFileRepository)
        {
            ReadAFileRepository = readAFileRepository;
        }

        public List<Absent> GetAttendanceList()
        {
            List<Absent> newList = ReadAFileRepository.ReadXMLFile();

            return newList;
        }
    }
}