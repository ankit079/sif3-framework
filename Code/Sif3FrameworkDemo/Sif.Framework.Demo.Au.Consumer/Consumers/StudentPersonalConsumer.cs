﻿/*
 * Copyright 2017 Systemic Pty Ltd
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Sif.Framework.Consumers;
using Sif.Framework.Demo.Au.Consumer.Models;
using System.Collections.Generic;
using Environment = Sif.Framework.Model.Infrastructure.Environment;

namespace Sif.Framework.Demo.Au.Consumer.Consumers
{

    class StudentPersonalConsumer : BasicConsumer<StudentPersonal>, ISupportsEvents<List<StudentPersonal>>
    {
        private static readonly slf4net.ILogger log = slf4net.LoggerFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StudentPersonalConsumer(string applicationKey, string instanceId = null, string userToken = null, string solutionId = null)
            : base(applicationKey, instanceId, userToken, solutionId)
        {
        }

        public StudentPersonalConsumer(Environment environment)
            : base(environment)
        {
        }

        public void OnCreateEvent(List<StudentPersonal> objs, string zoneId = null, string contextId = null)
        {
            if (log.IsDebugEnabled) log.Debug($"*** OnCreateEvent handler called ...");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Zone ID is {zoneId}.");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Context ID is {contextId}.");

            foreach (StudentPersonal student in objs)
            {
                if (log.IsDebugEnabled) log.Debug($"*** >>> Student created is {student.PersonInfo.Name.GivenName} {student.PersonInfo.Name.FamilyName}.");
            }

        }

        public void OnDeleteEvent(List<StudentPersonal> objs, string zoneId = null, string contextId = null)
        {
            if (log.IsDebugEnabled) log.Debug($"*** OnDeleteEvent handler called ...");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Zone ID is {zoneId}.");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Context ID is {contextId}.");

            foreach (StudentPersonal student in objs)
            {
                if (log.IsDebugEnabled) log.Debug($"*** >>> Student deleted is {student.PersonInfo.Name.GivenName} {student.PersonInfo.Name.FamilyName}.");
            }

        }

        public void OnErrorEvent(List<StudentPersonal> objs, string zoneId = null, string contextId = null)
        {
            if (log.IsDebugEnabled) log.Debug($"*** OnErrorEvent handler called ...");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Zone ID is {zoneId}.");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Context ID is {contextId}.");

            foreach (StudentPersonal student in objs)
            {
                if (log.IsDebugEnabled) log.Debug($"*** >>> Error with student {student.PersonInfo.Name.GivenName} {student.PersonInfo.Name.FamilyName}.");
            }

        }

        public void OnUpdateEvent(List<StudentPersonal> objs, string zoneId = null, string contextId = null)
        {
            if (log.IsDebugEnabled) log.Debug($"*** OnUpdateEvent handler called ...");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Zone ID is {zoneId}.");
            if (log.IsDebugEnabled) log.Debug($"*** >>> Context ID is {contextId}.");

            foreach (StudentPersonal student in objs)
            {
                if (log.IsDebugEnabled) log.Debug($"*** >>> Student updated is {student.PersonInfo.Name.GivenName} {student.PersonInfo.Name.FamilyName}.");
            }

        }

    }

}
