from segmentation import segmentation
from predict import predict
import os
os.environ['TF_CPP_MIN_LOG_LEVEL'] = '3'
import sys
import shutil


def main(img_path):
    roisFolder = '.\\rois'
    for filename in os.listdir(roisFolder):
        file_path = os.path.join(roisFolder, filename)
        try:
            if os.path.isfile(file_path) or os.path.islink(file_path):
                os.unlink(file_path)
            elif os.path.isdir(file_path):
                shutil.rmtree(file_path)
        except Exception as e:
            print('Failed to delete %s. Reason: %s' % (file_path, e))

    segmentation(img_path)

    roisFiles = os.listdir(roisFolder)
    roisFiles.sort(key=lambda f: int(''.join(filter(str.isdigit, f))))

    result = ""

    for roi in roisFiles:
        result += (predict(roisFolder + "\\" + roi) + " ")

    print(result)

if __name__ == '__main__':
    main(sys.argv[1])
