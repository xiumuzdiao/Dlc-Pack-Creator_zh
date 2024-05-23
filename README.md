# DLC包创建工具（Dlc Pack Creator）汉化版

效果图：

![效果图](https://github.com/xiumuzdiao/Dlc-Pack-Creator_zh/blob/main/pic/%E6%95%88%E6%9E%9C%E5%9B%BE.png)

## 快捷下载地址

[点此下载](https://github.com/xiumuzdiao/Dlc-Pack-Creator_zh/releases)

## 关于

该程序会在 dlc 包中生成自动填充..因此无需再进行设置！

英语原文件：https://zh.gta5-mods.com/tools/dlc-pack-creator

版权说明：[点击阅读](https://github.com/xiumuzdiao/Dlc-Pack-Creator_zh/tree/main?tab=MIT-1-ov-file)

## 使用说明

1. 在 Dlc Name Texbox 中输入您想要的 dlc 包名称...
2. 选择dlc包类型地图或车辆
3. 单击“创建 Dlc”并选择保存位置...
4. 将生成的 dlc 包拖放到 dlcpacks 文件夹中（文件位置：“Grand Theft Auto V\mods\update\x64\dlcpacks”）
5. 将 dlclist 复制并粘贴到 dlclist.xml 中（文件位置：“Grand Theft Auto V\mods\update\update.rpf\common\data）
6. 对于地图 dlc 包，将所有元文件（ymap、ytyp、.ymf）拖放到“dlcname”_metadata.rpf 内；将所有可绘制文件和碰撞文件（ydr、ydd、ybn）拖到“dlcname”.rpf 中
7. 对于车辆 dlc 包，将所有元数据文件（carcols、车辆等）拖放到“dlc.rpf/data”文件夹内；将 .gxt2 拖入 lang rpf 中；将所有.yft模型文件拖到vehicles.rpf中
