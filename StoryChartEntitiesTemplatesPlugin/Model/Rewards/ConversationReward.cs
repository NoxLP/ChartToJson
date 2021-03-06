﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryChart.Model.Rewards
{
    public class ConversationReward : NodeRewardWithGameObject
    {
        public ConversationReward()
        {
            Type = RewardsTypesEnum.Conversation;
        }

        #region Fields
        private string _ConversationId;
        #endregion

        #region Properties
        public string ConversationId
        {
            get { return _ConversationId; }
            set
            {
                if (value == null)
                {
                    if (_ConversationId != null)
                    {
                        _ConversationId = null;
                        OnPropertyChanged(nameof(ConversationId));
                    }
                }
                else if (!value.Equals(_ConversationId))
                {
                    _ConversationId = value;
                    OnPropertyChanged(nameof(ConversationId));
                }
            }
        }
        #endregion
    }
}
