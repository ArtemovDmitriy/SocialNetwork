using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.Tests
{
    public class MessageServiceTests
    {
        [Fact]
        public void SendMessageMustGetNotNullMessage()
        {
            string message = "��� �� ������ ���������";

            Assert.False(String.IsNullOrEmpty(message));
        }
        [Fact]
        public void SendMessageMustGetLengthNotMore5kChars()
        {
            string message = "��� �� ����� ������� ���������";

            Assert.True(message.Length < 5000);
        }
        [Fact]
        public void SendMessageMustSendMessage()
        {
            MessageRepository messageRepository = new MessageRepository();
            var messageEntity = new MessageEntity()
            {
                content = "������������ ���������",
                sender_id = 1,
                recipient_id = 2
            };

            Assert.False(messageRepository.Create(messageEntity) == 0);
        }
    }
}