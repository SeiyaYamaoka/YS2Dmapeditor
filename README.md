My English is not very good, please forgive me.

英語上手じゃないのでご容赦ください。

NAME
====
YS2Dmapeditor

#Overview

## Description
This is a map making tool for 2D games that I created when I was a student.

学生時代に作成した２Dゲーム用のマップ作製ツールです。

## DEMO
http://arrowya12.html.xdomain.jp/ArrowBlog/index02map2dedita/index02map2dedita01.html

Description in the folder

  -background

    background image

  -data

    Created map data

  -mapchip

    map chip image

  -play

    test game executable

   -setting

      ChipConfiguration.txt
      
        Map chip configuration file

          'chip=0/ratio=1,1{
          type=0/file=block.bmp/rect=0,0,32,32
          }'

          Image settings in the mapchip file. Then, specify the size.

          I tried to set the height and width of the image in the ratio, but it doesn't work.

      InitConfiguration.txt

        This is the first default setting to be loaded. When you quit the editor, the settings will be restored, so you can set them when you make the same game.
    
    
        COL_NUM=80

          number of horizontal blocks

        ROW_NUM=60

          number of vertical blocks

        BLO_SIZE=24

          Size of the block

        backbmpfilename=pipo-battlebg001.jpg

          background image

        MapChipSetFile=setting\ChipConfiguration.txt

          Map chip configuration file

        TestPlayfile=play\TransferZombie.exe

          テストゲーム用実行ファイル

        Mapdatafile=test6.txt

          初期読み込みファイル

---

フォルダ内の説明

  -background

    背景画像
    
  -data

    作成したマップデータ

  -mapchip

    マップチップ画像

  -play

    テストプレイ用実行ファイル

  -setting

    ChipConfiguration.txt

      マップチップの設定ファイル

      'chip=0/ratio=1,1{
      type=0/file=block.bmp/rect=0,0,32,32
      }'

      mapchipファイル内の画像設定。そのあとサイズを指定

      ratioで画像の縦横を設定しようとしたができてない。

    InitConfiguration.txt

      最初に読み込まれる初期設定です。エディタを終了すると設定されているものは元通りになるので同じゲームを作るとき設定する

      COL_NUM=80

        横ブロック数

      ROW_NUM=60

        縦ブロック数

      BLO_SIZE=24

        ブロックのサイズ

      backbmpfilename=pipo-battlebg001.jpg

        背景画像

      MapChipSetFile=setting\ChipConfiguration.txt

        マップチップの設定ファイル

      TestPlayfile=play\TransferZombie.exe

        テストゲーム用実行ファイル

      Mapdatafile=test6.txt

        初期読み込みファイル



## Usage
I don't know.

知らぬ

## Note
Probably an error if you enter an unexpected number

多分想定外の数値を入力するとエラーになります

## Author
Seiya Yamaoka

山岡征矢

