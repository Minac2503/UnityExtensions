using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NS
{
    public class Physics
    {
        public static Collider[] OverlapCapsule(Transform origin, float height, float width)
        {
            Collider[] result = new Collider[0];

            Collider[] found;
            found = UnityEngine.Physics.OverlapCapsule(new Vector3(origin.position.x, origin.position.y + height, origin.position.z),
                new Vector3(origin.position.x, origin.position.y - height, origin.position.z), width);
            List<Collider> list = new List<Collider>();
            int i = 0;
            while (i < found.Length)
            {
                RaycastHit hit;
                Vector3 fromPosition = origin.position;
                Vector3 toPosition = found[i].transform.position;
                Vector3 direction = toPosition - fromPosition;
                if (UnityEngine.Physics.Raycast(origin.position, direction, out hit, Mathf.Infinity))
                {
                    if (found[i].GetInstanceID() == hit.collider.GetInstanceID())
                    {
                        list.Add(hit.collider);
                    }
                }
                i++;
            }

            result = list.ToArray();

            return result;
        }
    }
}
