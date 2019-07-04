/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduleKeyDeletionResponse : AbstractModel
    {
        
        /// <summary>
        /// 计划删除执行时间
        /// </summary>
        [JsonProperty("DeletionDate")]
        public ulong? DeletionDate{ get; set; }

        /// <summary>
        /// 唯一标志被计划删除的CMK
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeletionDate", this.DeletionDate);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

