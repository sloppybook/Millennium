﻿using UnityEngine;

public interface ISelectable {

    Vector3 getGrabPoint();

    bool getActive();

    void onCursorSelect();

    void onCursorLeave();

    void onOKPressed();

    void onCancelPressed();

}
