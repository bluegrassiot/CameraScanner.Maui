using AndroidX.Camera.Core;

namespace CameraScanner.Maui.Platforms.Android
{
    class ImageCaptureCallback : ImageCapture.OnImageCapturedCallback
    {
        private readonly CameraManager cameraManager;

        public ImageCaptureCallback(CameraManager cameraManager)
        {
            this.cameraManager = cameraManager;
        }

        public override void OnCaptureSuccess(IImageProxy proxyImage)
        {
            this.cameraManager.CaptureImage(proxyImage);
        }

        public override void OnError(ImageCaptureException exception)
        {
            base.OnError(exception);
            // cameraManager.logger.LogError(exception, "Capture error");
        }
    }
}
