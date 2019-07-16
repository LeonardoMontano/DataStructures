
namespace DataStructuresLibrary
{
    public class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }
        public ListNode(T data)
        {
            this.Data = data;
        }
    }
}
