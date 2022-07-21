using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
public class LaserBeam : MonoBehaviour
{
    [SerializeField]
    private EdgeCollider2D edgeCollider2d;
    [SerializeField]
    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    [SerializeField]
    private void Start()
    {
        edgeCollider2d = this.GetComponent<EdgeCollider2D>();
        lineRenderer = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SetEdgeCollider(lineRenderer);
    }

    void SetEdgeCollider(LineRenderer line)
    {
        List<Vector2> edges = new List<Vector2>();

        for(int point = 0; point<lineRenderer.positionCount; point++)
        {
            Vector3 lineRendererPoint = line.GetPosition(point);
            edges.Add(new Vector2(lineRendererPoint.x, lineRendererPoint.y));
        }
        edgeCollider2d.SetPoints(edges);
    }
}
