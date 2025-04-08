using Core.Common;
using UnityEngine;

namespace Core.Bootstrap
{
    public class Bootstrap : MonoBehaviour
    {
        private void Start()
        {
            Language.Initialize();
            DirectoryPath.CheckDirectories();
        }
    }
}
