let element = null;
let component = null;
let observer = null;

function notify() {
    let bounds = element.getBoundingClientRect();
    component.invokeMethodAsync("NotifyBounds", bounds.left, bounds.top, element.clientWidth, element.clientHeight);
}

export function subscribe(measureElement, notifyObject) {
    element = measureElement;
    component = notifyObject;
    notify();

    observer = new ResizeObserver(_entries => {
        notify();
    });
    observer.observe(element);
}

export function unsubscribe() {
    if (observer != null) {
        observer.unobserve();
        observer = null;
    }    

    if (element != null) {
        element = null;
        component = null;
    }
}