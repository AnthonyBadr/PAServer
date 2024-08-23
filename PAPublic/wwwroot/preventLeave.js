window.preventNavigation = function (shouldPrevent) {
    if (shouldPrevent) {
        window.addEventListener('beforeunload', handleBeforeUnload);
    } else {
        window.removeEventListener('beforeunload', handleBeforeUnload);
    }
};

function handleBeforeUnload(event) {
    event.preventDefault();
    event.returnValue = '';
}
